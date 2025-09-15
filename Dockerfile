# stage build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["AspNetApi.csproj", "./"]
RUN dotnet restore "AspNetApi.csproj"

COPY . .

RUN dotnet publish "AspNetApi.csproj" --no-restore -c Release -o /app/publish /p:PublishSingleFile=false /p:PublishTrimmed=true

# stage runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine AS runtime
WORKDIR /app

RUN addgroup -S aspnetapp && adduser -S aspnetapp -G aspnetapp
USER aspnetapp

ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "AspNetApi.dll"]
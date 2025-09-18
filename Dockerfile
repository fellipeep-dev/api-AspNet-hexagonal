# stage build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

ENV NUGET_PACKAGES=/root/.nuget/packages
COPY ["Api/Api.csproj", "Api/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["api-AspNet-hexagonal.sln", "./"]

RUN dotnet restore "api-AspNet-hexagonal.sln" -r linux-musl-x64 --disable-parallel

COPY . .

RUN dotnet publish "Api/Api.csproj" --no-restore -c Release -o /app/publish /p:PublishSingleFile=false /p:PublishTrimmed=true -r linux-musl-x64

# stage runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS runtime
WORKDIR /app

RUN addgroup -S aspnetapp && adduser -S aspnetapp -G aspnetapp
USER aspnetapp

ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Api.dll"]
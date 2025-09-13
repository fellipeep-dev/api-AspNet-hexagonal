using AspNetApi.Api.Interfaces.User;
using AspNetApi.Application.Services.User.UseCases;

namespace AspNetApi.Application.Services.User
{
    public static class UserModuleDependency
    {
       public static IServiceCollection AddUserModule(this IServiceCollection services)
       {
           services.AddTransient<ICreateUserUseCase, CreateUserUseCase>();
           services.AddScoped<FindAllUsersUseCase>();
                 
           return services;
       }
    }
}
using Application.Services.User.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Services.User
{
    public static class UserModuleDependency
    {
       public static IServiceCollection AddUserModule(this IServiceCollection services)
       {
           services.AddTransient<ICreateUserUseCase, CreateUserUseCase>();
           services.AddTransient<IGetUserByIdUseCase, GetUserByIdUseCase>();
           services.AddTransient<IGetUsersUseCase, GetUsersUseCase>();
           services.AddTransient<IUpdateUserUseCase, UpdateUserUseCase>();
           services.AddTransient<IDeleteUserUseCase, DeleteUserUseCase>();
                 
           return services;
       }
    }
}
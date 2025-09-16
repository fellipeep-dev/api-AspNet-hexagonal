using AspNetApi.Application.Services.User.UseCases;

namespace AspNetApi.Application.Services.User
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
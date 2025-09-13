using AspNetApi.Application.Services.User;

namespace AspNetApi.Application
{
    public static class UserModuleDependency
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddUserModule();
        }
    }
}
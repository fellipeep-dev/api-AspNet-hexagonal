using Application.Services.User;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class UserModuleDependency
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddUserModule();
        }
    }
}
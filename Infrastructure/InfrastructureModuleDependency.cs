using Domain.User;
using Infrastructure.Repositories.User;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureModuleDependency
    {
        public static void AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
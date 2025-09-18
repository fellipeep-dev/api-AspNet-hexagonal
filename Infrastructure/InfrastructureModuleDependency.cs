using AspNetApi.Domain.User;
using AspNetApi.Infrastructure.Repositories.User;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetApi.Infrastructure
{
    public static class InfrastructureModuleDependency
    {
        public static void AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
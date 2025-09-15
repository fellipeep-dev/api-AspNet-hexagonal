using AspNetApi.Application.Interfaces.User;
using AspNetApi.Domain.Repositories.User;

namespace AspNetApi.Domain.Repositories
{
    public static class DomainModuleDependency
    {
        public static void AddDomainModule(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
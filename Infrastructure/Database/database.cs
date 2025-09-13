using AspNetApi.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace AspNetApi.Infrastructure.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<UserEntity> Users { get; set; }
    }
}

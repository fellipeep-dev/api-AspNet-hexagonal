using Microsoft.EntityFrameworkCore;
using AspNetApi.Application.Interfaces.User;
using AspNetApi.Infrastructure.Database;
using AspNetApi.Domain.Entities.User;

namespace AspNetApi.Domain.Repositories.User
{
    public class UserRepository(AppDbContext context) : IUserRepository
    {
        private readonly AppDbContext _context = context;

        public async Task AddUserAsync(UserEntity user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserEntity>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<UserEntity?> GetUserByIdAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task UpdateUserAsync(UserEntity user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(UserEntity user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}

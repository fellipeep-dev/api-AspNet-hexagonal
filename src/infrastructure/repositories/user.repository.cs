using AspNetApi.Src.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class UserRepository(AppDbContext context) : IUserRepository
{
  private readonly AppDbContext _context = context;

  public async Task AddUserAsync(UserEntity user)
  {
    await _context.Users.AddAsync(user);
    await _context.SaveChangesAsync();
  }

  public async Task<IEnumerable<UserEntity>> FindAllAsync()
  {
    return await _context.Users.ToListAsync();
  }
}
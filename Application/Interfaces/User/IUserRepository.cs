using AspNetApi.Domain.Entities.User;

namespace AspNetApi.Application.Interfaces.User
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> GetUsersAsync();
        Task AddUserAsync(UserEntity user);
        Task<UserEntity?> GetUserByIdAsync(Guid id);
        Task UpdateUserAsync(UserEntity user);
        Task DeleteUserAsync(UserEntity user);
    }
}

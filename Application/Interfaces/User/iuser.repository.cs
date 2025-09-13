using AspNetApi.Domain.Entities.User;

namespace AspNetApi.Application.Interfaces.User
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> FindAllAsync();
        Task AddUserAsync(UserEntity user);
    }
}

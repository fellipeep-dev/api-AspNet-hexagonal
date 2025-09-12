using AspNetApi.Src.Domain.Entities;

public interface IUserRepository
{
  Task<IEnumerable<UserEntity>> FindAllAsync();
  Task AddUserAsync(UserEntity user);
}
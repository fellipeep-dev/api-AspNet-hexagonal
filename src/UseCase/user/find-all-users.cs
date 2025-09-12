using AspNetApi.Src.Domain.Entities;

public class FindAllUsersUseCase(IUserRepository userRepository)
{
  private readonly IUserRepository _userRepository = userRepository;

  public async Task<IEnumerable<UserEntity>> ExecuteAsync()
  {
    return await _userRepository.FindAllAsync();
  }

}
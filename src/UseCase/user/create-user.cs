using AspNetApi.Src.Domain.Entities;

public class CreateUserUseCase(IUserRepository userRepository)
{
  private readonly IUserRepository _userRepository = userRepository;

  public async Task ExecuteAsync(string name, string email, DateOnly birthDate, string password)
  {
    var user = new UserEntity(name, email, birthDate, password);

    await _userRepository.AddUserAsync(user);
  }
}
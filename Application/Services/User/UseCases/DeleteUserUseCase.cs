using Domain.User;

namespace Application.Services.User.UseCases
{
  public class DeleteUserUseCase(IUserRepository userRepository) : IDeleteUserUseCase
  {
      private readonly IUserRepository _userRepository = userRepository;

      public async Task ExecuteAsync(Guid id)
      {        
          var userEntity = await _userRepository.GetUserByIdAsync(id) ?? throw new Exception("User not found");
          
          await _userRepository.DeleteUserAsync(userEntity);
      }
  }
}
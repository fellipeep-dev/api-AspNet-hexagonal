using AspNetApi.Application.Dtos.User;
using AspNetApi.Domain.User;

namespace AspNetApi.Application.Services.User.UseCases
{
    public class CreateUserUseCase(IUserRepository userRepository) : ICreateUserUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task ExecuteAsync(CreateUserDto createUserDto)
        {
            var user = new UserEntity(
                createUserDto.Name,
                createUserDto.Email,
                createUserDto.BirthDate,
                createUserDto.Password
            );

            await _userRepository.AddUserAsync(user);
        }
    }
}

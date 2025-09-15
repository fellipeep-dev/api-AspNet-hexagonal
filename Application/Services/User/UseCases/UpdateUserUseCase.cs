using AspNetApi.Api.Interfaces.User;
using AspNetApi.Application.Dtos.User;
using AspNetApi.Application.Interfaces.User;
using AspNetApi.Domain.Entities.User;

namespace AspNetApi.Application.Services.User.UseCases
{
    public class UpdateUserUseCase(IUserRepository userRepository) : IUpdateUserUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task ExecuteAsync(Guid id, UpdateUserDto updateUserDto)
        {
            var userEntity = await _userRepository.GetUserByIdAsync(id) ?? throw new Exception("User not found");

            var user = new UserEntity(
                updateUserDto.Name ?? userEntity.Name,
                updateUserDto.Email ?? userEntity.Email,
                updateUserDto.BirthDate ?? userEntity.BirthDate,
                updateUserDto.Password ?? userEntity.Password
            );

            await _userRepository.UpdateUserAsync(user);
        }
        
    }
}
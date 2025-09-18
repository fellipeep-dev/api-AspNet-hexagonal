using Application.Dtos.User;
using Domain.User;

namespace Application.Services.User.UseCases
{
    public class UpdateUserUseCase(IUserRepository userRepository) : IUpdateUserUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task ExecuteAsync(UpdateUserDto updateUserDto)
        {
            var userEntity = await _userRepository.GetUserByIdAsync(updateUserDto.Id) ?? throw new Exception("User not found");

            userEntity.Update(
                updateUserDto.Name ?? userEntity.Name,
                updateUserDto.Email ?? userEntity.Email,
                updateUserDto.BirthDate ?? userEntity.BirthDate,
                updateUserDto.Password ?? userEntity.Password
            );

            await _userRepository.UpdateUserAsync(userEntity);
        }
        
    }
}
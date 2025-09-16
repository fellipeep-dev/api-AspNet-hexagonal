using AspNetApi.Domain.User;

namespace AspNetApi.Application.Services.User.UseCases
{
    public class GetUserByIdUseCase(IUserRepository userRepository) : IGetUserByIdUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<UserEntity> ExecuteAsync(Guid id)
        {
            return await _userRepository.GetUserByIdAsync(id) ?? throw new Exception("User not found");
        }
    }
}
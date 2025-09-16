using AspNetApi.Domain.User;

namespace AspNetApi.Application.Services.User.UseCases
{
    public class GetUsersUseCase(IUserRepository userRepository) : IGetUsersUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<IEnumerable<UserEntity>> ExecuteAsync()
        {
            return await _userRepository.GetUsersAsync();
        }
    }
}
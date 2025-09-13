using AspNetApi.Application.Interfaces.User;
using AspNetApi.Domain.Entities.User;

namespace AspNetApi.Application.Services.User.UseCases
{
    public class FindAllUsersUseCase(IUserRepository userRepository)
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<IEnumerable<UserEntity>> ExecuteAsync()
        {
            return await _userRepository.FindAllAsync();
        }

    }
}
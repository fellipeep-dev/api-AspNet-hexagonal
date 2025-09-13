using AspNetApi.Application.Interfaces.User;

namespace AspNetApi.Application.Services.User.UseCases
{
    public class UpdateUserUseCase(IUserRepository userRepository)
    {
        private readonly IUserRepository _userRepository = userRepository;
    }
}
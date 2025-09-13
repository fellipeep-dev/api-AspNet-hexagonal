using AspNetApi.Application.Dtos.User;

namespace AspNetApi.Api.Interfaces.User
{
    public interface ICreateUserUseCase
    {
        Task ExecuteAsync(CreateUserDto createUserDto);
    }
}
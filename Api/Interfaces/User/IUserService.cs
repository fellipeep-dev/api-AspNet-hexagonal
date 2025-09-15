using AspNetApi.Application.Dtos.User;
using AspNetApi.Domain.Entities.User;

namespace AspNetApi.Api.Interfaces.User
{
    public interface ICreateUserUseCase
    {
        Task ExecuteAsync(CreateUserDto createUserDto);
    }
    public interface IGetUsersUseCase
    {
        Task<IEnumerable<UserEntity>> ExecuteAsync();
    }
    public interface IGetUserByIdUseCase
    {
        Task<UserEntity> ExecuteAsync(Guid id);
    }
    public interface IUpdateUserUseCase
    {
        Task ExecuteAsync(Guid id, UpdateUserDto updateUserDto);
    }
    public interface IDeleteUserUseCase
    {
        Task ExecuteAsync(Guid id);
    }
}
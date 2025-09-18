using Application.Dtos.User;
using Domain.User;

namespace Application.Services.User
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
        Task ExecuteAsync(UpdateUserDto updateUserDto);
    }
    public interface IDeleteUserUseCase
    {
        Task ExecuteAsync(Guid id);
    }
}
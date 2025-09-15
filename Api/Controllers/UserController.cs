using AspNetApi.Api.Interfaces.User;
using AspNetApi.Application.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(
    ) : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(
            [FromBody] CreateUserDto createUserDto,
            [FromServices] ICreateUserUseCase _createUserUseCase
        )
        {
            await _createUserUseCase.ExecuteAsync(createUserDto);

            return Ok(new { Message = "User created successfully" });
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetUsers(
            [FromServices] IGetUsersUseCase _getUsersUseCase
        )
        {
            var users = await _getUsersUseCase.ExecuteAsync();

            return Ok(users);
        }

        [HttpGet("get/{id:guid}")]
        public async Task<IActionResult> GetUserById(
            [FromRoute] Guid id,
            [FromServices] IGetUserByIdUseCase _getUserByIdUseCase
        )
        {
            var user = await _getUserByIdUseCase.ExecuteAsync(id);

            return Ok(user);
        }

        [HttpPut("update/{id:guid}")]
        public async Task<IActionResult> UpdateUser(
            [FromRoute] Guid id,
            [FromBody] UpdateUserDto updateUserDto,
            [FromServices] IUpdateUserUseCase _updateUserUseCase
        )
        {
            await _updateUserUseCase.ExecuteAsync(id, updateUserDto);

            return Ok(new { Message = "User updated successfully" });
        }

        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> DeleteUser(
            [FromRoute] Guid id,
            [FromServices] IDeleteUserUseCase _deleteUserUseCase)
        {
            await _deleteUserUseCase.ExecuteAsync(id);

            return Ok(new { Message = "User deleted successfully" });
        }
    }
}



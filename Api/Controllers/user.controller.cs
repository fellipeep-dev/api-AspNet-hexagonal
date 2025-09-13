using AspNetApi.Api.Interfaces.User;
using AspNetApi.Application.Dtos.User;
using AspNetApi.Application.Services.User.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(ICreateUserUseCase createUserUseCase, FindAllUsersUseCase findAllUsersUseCase) : ControllerBase
    {
        private readonly ICreateUserUseCase _createUserUseCase = createUserUseCase;
        private readonly FindAllUsersUseCase _findAllUsersUseCase = findAllUsersUseCase;

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            await _createUserUseCase.ExecuteAsync(createUserDto);

            return Ok(new { Message = "User created successfully" });
        }

        [HttpGet("find-all")]
        public async Task<IActionResult> FindAllUsers()
        {
            var users = await _findAllUsersUseCase.ExecuteAsync();

            return Ok(users);
        }
    }
}



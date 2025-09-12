using AspNetApi.Src.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApi.Src.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(CreateUserUseCase createUserUseCase, FindAllUsersUseCase findAllUsersUseCase) : ControllerBase
{
    private readonly CreateUserUseCase _createUserUseCase = createUserUseCase;
    private readonly FindAllUsersUseCase _findAllUsersUseCase = findAllUsersUseCase;

    [HttpPost("create")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDto request)
    {
        await _createUserUseCase.ExecuteAsync(request.Name, request.Email, request.BirthDate, request.Password);

        return Ok(new { Message = "User created successfully" });
    }

    [HttpGet("find-all")]
    public async Task<IActionResult> FindAllUsers()
    {
        var users = await _findAllUsersUseCase.ExecuteAsync();

        return Ok(users);
    }
}

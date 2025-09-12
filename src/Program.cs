using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<CreateUserUseCase>();
builder.Services.AddScoped<FindAllUsersUseCase>();
builder.Services.AddControllers();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();

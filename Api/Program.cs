using AspNetApi.Application;
using AspNetApi.Domain.Repositories;
using AspNetApi.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDomainModule();
builder.Services.AddApplicationModule();
builder.Services.AddControllers();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();

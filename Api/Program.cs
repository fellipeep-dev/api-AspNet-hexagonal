using Application;
using Infrastructure;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
    
builder.Services.AddInfrastructureModule();
builder.Services.AddApplicationModule();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

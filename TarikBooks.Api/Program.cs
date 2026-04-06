using TarikBooks.Dal;
using TarikBooks.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDalServices(builder.Configuration);

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
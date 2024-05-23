using Microsoft.EntityFrameworkCore;
using RepositoryPattern.DataAccess.Context;

var builder = WebApplication.CreateBuilder(args);

IServiceCollection _services = builder.Services;
ConfigurationManager _configuration = builder.Configuration;

// Add services to the container.

_services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(_configuration.GetConnectionString("RepositoryPatternContext")));

_services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
_services.AddEndpointsApiExplorer();
_services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

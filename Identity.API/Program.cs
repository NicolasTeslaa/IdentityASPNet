using AutoMapper;
using Identity.API.ViewModels;
using Identity.Domain.Entities;
using Identity.Infra.Context;
using Identity.Services.DTO;
using Identity.Services.Interfaces;
using Identity.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region AutoMapper
var autoMapperConfig = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<User, UserDTO>().ReverseMap();
    cfg.CreateMap<CreateUserViewModel, UserDTO>().ReverseMap();
});
#endregion

#region DI
// erro na linha abaixo Exited with error code -532462766
builder.Services.AddScoped<IUserService, UserService>();
#endregion

builder.Services.AddDbContext<ManagerContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Banco"))
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
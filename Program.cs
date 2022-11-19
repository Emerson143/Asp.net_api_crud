using System.Security.AccessControl;
using System.Collections.Immutable;
using Asp.net_api_crud.Data;
using Microsoft.EntityFrameworkCore;
using Asp.net_api_crud.Repository;
using Asp.net_api_crud.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UsuarioContext>(options => {
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
}
);

builder.Services.AddScoped<IUusuarioRepository, UsuarioRepository>();

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

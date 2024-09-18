using Microsoft.OpenApi.Models;
using MinimalApi.Configuration;
using MinimalApi.Endpoints;
using MinimalApi.Endpoints.AddGame;
using MinimalApi.Shared;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddAuthorization();
services.AddAuthentication("Bearer").AddJwtBearer();

services.AddSingleton<IGameStorage, GameStorage>();
services.AddSingleton<AddGameRequestValidator>();

services.AddSwaggerConfiguration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapEndpoints();

app.Run();

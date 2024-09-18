using MinimalApi.Endpoints;
using MinimalApi.Endpoints.AddGame;
using MinimalApi.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IBoardGameStorage, BoardGameStorage>();
builder.Services.AddSingleton<AddGameRequestValidator>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapEndpoints();

app.Run();

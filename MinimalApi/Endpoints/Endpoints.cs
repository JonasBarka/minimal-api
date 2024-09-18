using MinimalApi.Endpoints.AddGame;
using MinimalApi.Endpoints.GetGame;

namespace MinimalApi.Endpoints;

public static class Endpoints
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapGetGame();
        app.MapAddGame();
    }
}

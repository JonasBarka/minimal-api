using MinimalApi.Endpoints.AddGame;

namespace MinimalApi.Endpoints;

public static class Endpoints
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapAddGame();
    }
}

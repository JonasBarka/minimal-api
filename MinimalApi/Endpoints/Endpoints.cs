using MinimalApi.Endpoints.GetHello;

namespace MinimalApi.Endpoints;

public static class Endpoints
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapGetHello();
    }
}

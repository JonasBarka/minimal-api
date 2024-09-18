using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi.Shared;

namespace MinimalApi.Endpoints.AddGame;

public static class GetGame
{
    public static void MapAddGame(this WebApplication app)
    {
        app.MapPost("/boardgame", GetGame.Handle)
            .WithName("AddGame")
            .RequireAuthorization();
    }

    public static Results<Ok<AddGameResponse>, BadRequest<string>> Handle(
        IGameStorage storage,
        AddGameRequestValidator validator,
        AddGameRequest request)
    {
        var results = validator.Validate(request);

        if (!results.IsValid)
        {
            return TypedResults.BadRequest(results.ToString());
        }

        var boardGame = request.ToBoardGame(Guid.NewGuid(), DateOnly.FromDateTime(DateTime.UtcNow));

        storage.Games.Add(boardGame);

        return TypedResults.Ok(boardGame.ToAddBoardGameResponse());
    }
}

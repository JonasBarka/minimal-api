using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi.Shared;

namespace MinimalApi.Endpoints.AddGame;

public static class AddGame
{
    public static void MapAddGame(this WebApplication app)
    {
        app.MapPost("/boardgame", AddGame.Handle)
            .WithName("AddGame");
    }

    public static Results<Ok<AddGameResponse>, BadRequest<string>> Handle(
        IBoardGameStorage storage,
        AddGameRequestValidator validator,
        AddGameRequest request)
    {
        var results = validator.Validate(request);

        if (!results.IsValid)
        {
            return TypedResults.BadRequest(results.ToString());
        }

        var boardGame = request.ToBoardGame(Guid.NewGuid(), DateOnly.FromDateTime(DateTime.UtcNow));

        storage.BoardGames.Add(boardGame);

        return TypedResults.Ok(boardGame.ToAddBoardGameResponse());
    }
}

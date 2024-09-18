using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi.Shared;

namespace MinimalApi.Endpoints.GetGame;

public static class GetGame
{
    public static void MapGetGame(this WebApplication app)
    {
        app.MapGet("/boardgame", GetGame.Handle)
            .WithName("GetGame");
    }

    public static Results<Ok<List<GetGameResponse>>, NotFound<string>> Handle(
        IGameStorage storage,
        Guid? Id)
    {
        if (Id.HasValue)
        {
            var game = storage.Games.FirstOrDefault(x => x.Id == Id.Value);

            if (game is null)
            {
                return TypedResults.NotFound($"Game with id {Id} not found");
            }

            return TypedResults.Ok(new List<GetGameResponse> { game.ToAddBoardGameResponse() });
        }

        var games = storage.Games.ToAddGameResponses();

        return TypedResults.Ok(games);
    }
}

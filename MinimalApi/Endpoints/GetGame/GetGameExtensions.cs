using MinimalApi.Shared;

namespace MinimalApi.Endpoints.GetGame;

public static class GetGameExtensions
{
    public static GetGameResponse ToAddBoardGameResponse(this Game game)
    {
        return new GetGameResponse(game.Id, game.CreatedDate, game.Name, game.MinPlayers, game.MaxPlayers, game.Categories);
    }

    public static List<GetGameResponse> ToAddGameResponses(this List<Game> games)
    {
        return games.Select(x => x.ToAddBoardGameResponse()).ToList();
    }
}

using MinimalApi.Shared;

namespace MinimalApi.Endpoints.AddGame;

public static class GetGameExtensions
{
    public static Game ToBoardGame(this AddGameRequest request, Guid id, DateOnly createdDate)
    {
        return new Game
        {
            Id = id,
            CreatedDate = createdDate,
            Name = request.Name,
            MinPlayers = request.MinPlayers,
            MaxPlayers = request.MaxPlayers,
            Categories = request.Categories
        };
    }

    public static AddGameResponse ToAddBoardGameResponse(this Game boardGame)
    {
        return new AddGameResponse(boardGame.Id, boardGame.CreatedDate, boardGame.Name, boardGame.MinPlayers, boardGame.MaxPlayers, boardGame.Categories);
    }
}

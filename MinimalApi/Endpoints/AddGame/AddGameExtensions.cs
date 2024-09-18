using MinimalApi.Shared;

namespace MinimalApi.Endpoints.AddGame;

public static class AddGameExtensions
{
    public static BoardGame ToBoardGame(this AddGameRequest request, Guid id, DateOnly createdDate)
    {
        return new BoardGame
        {
            Id = id,
            CreatedDate = createdDate,
            Name = request.Name,
            MinPlayers = request.MinPlayers,
            MaxPlayers = request.MaxPlayers,
            Categories = request.Categories
        };
    }

    public static AddGameResponse ToAddBoardGameResponse(this BoardGame boardGame)
    {
        return new AddGameResponse(boardGame.Id, boardGame.CreatedDate, boardGame.Name, boardGame.MinPlayers, boardGame.MaxPlayers, boardGame.Categories);
    }
}

namespace MinimalApi.Shared;

public interface IBoardGameStorage
{
    List<BoardGame> BoardGames { get; }
}

public class BoardGameStorage : IBoardGameStorage
{
    public List<BoardGame> BoardGames { get; } = [];
}

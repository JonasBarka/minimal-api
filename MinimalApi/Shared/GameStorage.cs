namespace MinimalApi.Shared;

public interface IGameStorage
{
    List<Game> Games { get; }
}

public class GameStorage : IGameStorage
{
    public List<Game> Games { get; } = [];
}

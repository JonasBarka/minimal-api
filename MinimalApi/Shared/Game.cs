namespace MinimalApi.Shared;

public class Game
{
    public required Guid Id { get; init; }
    public required DateOnly CreatedDate { get; init; }
    public required string Name { get; init; }
    public required int MinPlayers { get; init; }
    public required int MaxPlayers { get; init; }
    public required List<string> Categories { get; init; }
}

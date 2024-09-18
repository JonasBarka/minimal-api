namespace MinimalApi.Endpoints.AddGame;

public record AddGameResponse(
    Guid Id,
    DateOnly CreatedDate,
    string Name,
    int MinPlayers,
    int MaxPlayers,
    List<string> Categories);

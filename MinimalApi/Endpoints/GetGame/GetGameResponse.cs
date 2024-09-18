namespace MinimalApi.Endpoints.GetGame;

public record GetGameResponse(
    Guid Id,
    DateOnly CreatedDate,
    string Name,
    int MinPlayers,
    int MaxPlayers,
    List<string> Categories);

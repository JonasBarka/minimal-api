namespace MinimalApi.Endpoints.AddGame;

public record AddGameRequest(
    string Name,
    int MinPlayers,
    int MaxPlayers,
    List<string> Categories);

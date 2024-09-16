using Microsoft.AspNetCore.Http.HttpResults;

namespace MinimalApi.Endpoints.GetHello;

public static class GetHello
{

    public static void MapGetHello(this WebApplication app)
    {
        app.MapGet("/hello", GetHello.Handle)
            .WithName("GetHello")
            .WithOpenApi(generatedOperation =>
            {
                var parameter = generatedOperation.Parameters[0];
                parameter.Description = "The name of the person to be greeted";
                return generatedOperation;
            });
    }

    public static Results<Ok<GetHelloResponse>, BadRequest<string>> Handle (string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return TypedResults.BadRequest("A name containing non-whitespace characters must be included.");
        }

        name = name.Trim();

        return TypedResults.Ok(new GetHelloResponse($"Hello {name}!"));
    }
}

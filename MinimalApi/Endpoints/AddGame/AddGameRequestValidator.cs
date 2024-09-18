using FluentValidation;

namespace MinimalApi.Endpoints.AddGame;

public class AddGameRequestValidator : AbstractValidator<AddGameRequest>
{
    public AddGameRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();

        RuleFor(x => x.MinPlayers)
            .GreaterThan(0);

        RuleFor(x => x.MaxPlayers)
            .GreaterThanOrEqualTo(x => x.MinPlayers);

        RuleFor(x => x.Categories)
            .NotNull();

        RuleForEach(x => x.Categories)
            .NotEmpty()
            .WithMessage("All members of 'Categories' must not be empty.");
    }
}

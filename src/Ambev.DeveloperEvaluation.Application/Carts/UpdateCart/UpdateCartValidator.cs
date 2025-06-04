using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart;

public class UpdateCartCommandValidator : AbstractValidator<UpdateCartCommand>
{
	public UpdateCartCommandValidator()
	{
        RuleFor(x => x.Id)
        .NotEmpty()
        .WithMessage("Cart ID is required");
    }
}
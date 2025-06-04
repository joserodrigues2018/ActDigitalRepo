using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
	public UpdateProductCommandValidator()
	{
        RuleFor(x => x.Id)
        .NotEmpty()
        .WithMessage("Product ID is required");
    }
}
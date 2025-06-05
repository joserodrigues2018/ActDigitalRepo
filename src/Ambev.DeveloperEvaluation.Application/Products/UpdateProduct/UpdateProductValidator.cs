using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
	public UpdateProductCommandValidator()
	{
        RuleFor(x => x.Id).NotEmpty().WithMessage("Product ID is required");
        RuleFor(product => product.Title).NotEmpty().WithMessage("title is required");
        RuleFor(product => product.Description).NotEmpty().WithMessage("Description is required");
        RuleFor(product => product.Price).NotEmpty().WithMessage("Price is required");
        RuleFor(product => product.Category).NotEmpty().WithMessage("Price is required");

    }
}
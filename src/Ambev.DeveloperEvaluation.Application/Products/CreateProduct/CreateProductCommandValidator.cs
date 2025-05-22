using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    /// <summary>
    /// CreateProductCommandValidator
    /// </summary>
    public class CreateProductCommandValidator: AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(product => product.Title).NotEmpty().WithMessage("title is required");
            RuleFor(product => product.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(product => product.Price).NotEmpty().WithMessage("Price is required");
            RuleFor(product => product.Category).NotEmpty().WithMessage("Price is required");
        }
    }
}

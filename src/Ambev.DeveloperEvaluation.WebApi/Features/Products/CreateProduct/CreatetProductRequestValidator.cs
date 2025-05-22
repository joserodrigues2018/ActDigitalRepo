using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    public class CreatetProductRequestValidator: AbstractValidator<CreateProductResquest>
    {
        public CreatetProductRequestValidator()
        {
            RuleFor(product => product.Title).NotEmpty().WithMessage("title is required");
            RuleFor(product => product.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(product => product.Price).NotEmpty().WithMessage("Price is required");
            RuleFor(product => product.Category).NotEmpty().WithMessage("Price is required");

        }
    }
}

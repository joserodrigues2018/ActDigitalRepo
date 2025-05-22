
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct
{
    public class GetProductRequestValidator: AbstractValidator<GetProductResquest>
    {
        public GetProductRequestValidator()
        {
            RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Product ID is required");
        }
    }
}

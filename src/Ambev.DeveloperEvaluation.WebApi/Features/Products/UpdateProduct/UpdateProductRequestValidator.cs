using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    public class UpdatetProductRequestValidator: AbstractValidator<UpdateProductIdRequest>
    {
        public UpdatetProductRequestValidator()
        {
            RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Product ID is required");
        }
    }
}

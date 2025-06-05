using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    public class UpdatetProductRequestValidator: AbstractValidator<UpdateProductIdRequest>
    {
        public UpdatetProductRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Product ID is required");
            RuleFor(product => product.Request!.Title).NotEmpty().WithMessage("title is required");
            RuleFor(product => product.Request!.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(product => product.Request!.Price).NotEmpty().WithMessage("Price is required");
            RuleFor(product => product.Request!.Category).NotEmpty().WithMessage("Price is required");

        }
    }
}

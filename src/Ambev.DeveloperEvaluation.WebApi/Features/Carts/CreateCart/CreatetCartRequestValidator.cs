using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreatetCartRequestValidator: AbstractValidator<CreateCartResquest>
    {
        public CreatetCartRequestValidator()
        {
            RuleFor(cart => cart.UserId).NotEmpty().WithMessage("UserId is required");
            RuleFor(cart => cart.ProductId).NotEmpty().WithMessage("ProductId is required");
            RuleFor(cart => cart.Quantity).NotEmpty().WithMessage("Quantity is required");

        }
    }
}

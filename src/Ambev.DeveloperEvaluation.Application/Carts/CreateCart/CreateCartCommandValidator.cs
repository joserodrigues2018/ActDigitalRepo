using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    /// <summary>
    /// CreateCartCommandValidator
    /// </summary>
    public class CreateCartCommandValidator: AbstractValidator<CreateCartCommand>
    {
        public CreateCartCommandValidator()
        {
            RuleFor(cart => cart.UserId).NotEmpty().WithMessage("UserId is required");
            RuleFor(cart => cart.ProductId).NotEmpty().WithMessage("ProductId is required");
            RuleFor(cart => cart.Quantity).NotEmpty().WithMessage("Quantity is required");
        }
    }
}

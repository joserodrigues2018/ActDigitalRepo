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
        }
    }
}

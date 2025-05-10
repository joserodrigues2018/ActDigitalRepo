using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreatetCartRequestValidator: AbstractValidator<CreateCartResquest>
    {
        public CreatetCartRequestValidator()
        {
            RuleFor(cart => cart.UserId).NotEmpty().WithMessage("UserId is required");
        }
    }
}

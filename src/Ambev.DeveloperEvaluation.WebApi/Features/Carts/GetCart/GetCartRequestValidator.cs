
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart
{
    public class GetCartRequestValidator: AbstractValidator<GetCartResquest>
    {
        public GetCartRequestValidator()
        {
            RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Cart ID is required");
        }
    }
}

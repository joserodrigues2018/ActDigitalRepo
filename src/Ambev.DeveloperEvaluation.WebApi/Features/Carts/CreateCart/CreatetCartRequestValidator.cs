﻿using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreatetCartRequestValidator: AbstractValidator<CreateCartResquest>
    {
        public CreatetCartRequestValidator()
        {
            RuleFor(cart => cart.UserId).NotEmpty().WithMessage("UserId is required");
            RuleFor(cart => cart.CartItens).NotNull().WithMessage("CartItems is requiride");

            RuleForEach(cart => cart.CartItens).ChildRules(item =>
            {
                item.RuleFor(x => x.Quantity < 0).NotNull().WithMessage("Quanmtity is negative");
                item.RuleFor(x => x.Quantity).NotNull().NotEqual(0).WithMessage("Qunatity is required");
                item.RuleFor(x => x.Quantity).NotNull().GreaterThanOrEqualTo(1).LessThanOrEqualTo(20)
                                             .WithMessage("Maximum limit: 20 items per product");


            });

        }
    }
}

using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Domain.Rules
{
    public class RulesDiscountCart : IRulesDiscountCart
    {
        private readonly ICalcDiscount _calcDiscount;

        public RulesDiscountCart(ICalcDiscount calcDiscount)
        {
            _calcDiscount = calcDiscount;
        }

        public async Task<CartItem> DiscountCart(CartItem cartItem, CancellationToken cancellationToken)
        {

            var valorItem = (cartItem.Quantity * cartItem.UnitPrice);

            if (cartItem.Quantity >= 4 && cartItem.Quantity <= 9)
            {
                cartItem.Discount = 10;
            }
            else if (cartItem.Quantity >= 10 && cartItem.Quantity <= 20)
            {
                cartItem.Discount = 20;
            }
            else
            {
                cartItem.Discount = 0;
            }

            cartItem.ValueTotIten = await _calcDiscount.ApplyDiscount(cartItem.UnitPrice, cartItem.Quantity, cartItem.Discount);

            cartItem.StatusIten = CartStatus.VendaCriada;      

            return cartItem;
        }
    }
}

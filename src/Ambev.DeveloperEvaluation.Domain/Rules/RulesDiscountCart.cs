using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Domain.Rules
{
    public class RulesDiscountCart : IRulesDiscountCart
    {
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

            cartItem.ValueTotIten = await ApplyDiscount(cartItem.UnitPrice, cartItem.Quantity, cartItem.Discount);

            cartItem.StatusIten = CartStatus.VendaCriada;      

            return cartItem;
        }

        private Task<decimal> ApplyDiscount(decimal unitPrice, int quantItem, int percent)
        {
            return Task.FromResult(percent == 0 ? (quantItem * unitPrice) : (quantItem * unitPrice) - (quantItem * unitPrice * percent) / 100);
        }
    }
}

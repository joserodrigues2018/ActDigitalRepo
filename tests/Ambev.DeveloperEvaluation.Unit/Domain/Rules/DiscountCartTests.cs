using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Rules;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentAssertions;
using Xunit;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain
{
    public class DiscountCartTests
    {
        private readonly RulesDiscountCart _discountCart;

        public DiscountCartTests()
        {
            _discountCart = new RulesDiscountCart();
        }

        [Fact(DisplayName = "Test unit sucess discount cartItem rule 10% Discount")]
        public async Task ApplyDiscount_CartItem_Percent10_Sucess()
        {
            Faker<CartItem> cartItemFaker = new Faker<CartItem>().CustomInstantiator( c => new CartItem()
            {
                Id = c.Random.Guid(),
                CartId = c.Random.Guid(),
                ProductId = c.Random.Guid().ToString(),
                Quantity = 8,
                UnitPrice = 12.50m,
                StatusIten = CartStatus.VendaCriada,
                Discount = 0,
                ValueTotIten = 0
            });

            var cartItem = await _discountCart.DiscountCart(cartItemFaker, CancellationToken.None);

            cartItem.Should().NotBeNull();
            cartItem.StatusIten.Equals(cartItemFaker.Equals(CartStatus.VendaCriada));
        }
    }
}

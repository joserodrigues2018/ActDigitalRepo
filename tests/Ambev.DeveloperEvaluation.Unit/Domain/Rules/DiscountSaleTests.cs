using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Rules;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentAssertions;
using Xunit;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain
{
    public class DiscountSaleTests
    {
        private readonly RulesDiscountSale _discountSale;

        public DiscountSaleTests()
        {
            _discountSale = new RulesDiscountSale();
        }

        [Fact(DisplayName = "Test unit sucess discount saleItem rule 10% Discount")]
        public async Task ApplyDiscount_CartItem_Percent10_Sucess()
        {
            Faker<SaleOrderItem> saleItemFaker = new Faker<SaleOrderItem>().CustomInstantiator( c => new SaleOrderItem()
            {
                Id = c.Random.Guid(),
                SaleOrderId = c.Random.Guid(),
                ProductId = c.Random.Guid().ToString(),
                Quantity = 8,
                UnitPrice = 12.50m,
                PercentDiscount = 0,
                ValueTotIten = 0
            });

            var saleItem = await _discountSale.DiscountSale(saleItemFaker, CancellationToken.None);

            saleItem.Should().NotBeNull();
        }

        [Fact(DisplayName = "Test unit sucess discount saleItem rule 20% Discount")]
        public async Task ApplyDiscount_CartItem_Percent20_Sucess()
        {
            Faker<SaleOrderItem> saleItemFaker = new Faker<SaleOrderItem>().CustomInstantiator(c => new SaleOrderItem()
            {
                Id = c.Random.Guid(),
                SaleOrderId = c.Random.Guid(),
                ProductId = c.Random.Guid().ToString(),
                Quantity = 18,
                UnitPrice = 12.50m,
                PercentDiscount = 0,
                ValueTotIten = 0
            });

            var saleItem = await _discountSale.DiscountSale(saleItemFaker, CancellationToken.None);

            saleItem.Should().NotBeNull();
        }
        [Fact(DisplayName = "Test unit sucess discount cartItem rule 0% Discount")]
        public async Task ApplyDiscount_CartItem_PercentZero_Sucess()
        {
            Faker<SaleOrderItem> saleItemFaker = new Faker<SaleOrderItem>().CustomInstantiator(c => new SaleOrderItem()
            {
                Id = c.Random.Guid(),
                SaleOrderId = c.Random.Guid(),
                ProductId = c.Random.Guid().ToString(),
                Quantity = 2,
                UnitPrice = 12.50m,
                PercentDiscount = 0,
                ValueTotIten = 0
            });

            var saleItem = await _discountSale.DiscountSale(saleItemFaker, CancellationToken.None);

            saleItem.Should().NotBeNull();
        }
    }
}

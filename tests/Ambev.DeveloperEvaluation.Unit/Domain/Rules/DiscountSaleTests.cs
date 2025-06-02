using Ambev.DeveloperEvaluation.Domain.Rules;
using FluentAssertions;
using Xunit;
using Ambev.DeveloperEvaluation.Unit.Domain.Rules;
using Ambev.DeveloperEvaluation.Domain.Enums;

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
        public  void ApplyDiscount_CartItem_Percent10_Sucess()
        {
            var saleOrderFaker = DiscountSaleTestData.GenerateCartFaker();

            var saleOrder = _discountSale.DiscountSale(saleOrderFaker, CancellationToken.None);

            saleOrder.Should().NotBeNull();
            saleOrder.Status.Should().Be(SaleStatus.VendaCriada);
        }

        [Fact(DisplayName = "Test unit sucess discount saleItem rule 20% Discount")]
        public void ApplyDiscount_CartItem_Percent20_Sucess()
        {
            var saleOrderFaker = DiscountSaleTestData.GenerateCartFaker();

            var saleOrder = _discountSale.DiscountSale(saleOrderFaker, CancellationToken.None);

            saleOrder.Should().NotBeNull();
            saleOrder.Status.Should().Be(SaleStatus.VendaCriada);


        }
        [Fact(DisplayName = "Test unit sucess discount cartItem rule 0% Discount")]
        public void ApplyDiscount_CartItem_PercentZero_Sucess()
        {
            var saleOrderFaker = DiscountSaleTestData.GenerateCartFaker();

            var saleOrder = _discountSale.DiscountSale(saleOrderFaker, CancellationToken.None);

            saleOrder.Should().NotBeNull();
            saleOrder.Status.Should().Be(SaleStatus.VendaCriada);

        }
    }
}

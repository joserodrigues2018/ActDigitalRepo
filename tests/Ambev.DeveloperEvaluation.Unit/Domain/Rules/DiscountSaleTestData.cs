using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Rules
{
    public  static class DiscountSaleTestData
    {
        private static readonly Faker<SaleOrderItem> _saleOrderItem = new Faker<SaleOrderItem>()
                                .RuleFor(i => i.SaleOrderId, f => f.Random.Guid())
                                .RuleFor(i => i.ProductId, f => f.Random.Guid().ToString())
                                .RuleFor(i => i.Quantity, f => f.Random.Number(1, 20))
                                .RuleFor(i => i.UnitPrice, f => f.Random.Number(1, 20));

        private static readonly Faker<SaleOrder> _saleOrderFaker = new Faker<SaleOrder>()
                                .RuleFor(c => c.CartId, f => f.Random.Guid())
                                .RuleFor(c => c.NumeroVenda, f => f.Random.Number())
                                .RuleFor(c => c.SaleDate, DateTime.Now)
                                .RuleFor( c => c.Client, f=> f.Person.FullName)
                                .RuleFor( c=> c.Filial, f => f.Company.CompanyName())
                                .RuleFor( c => c.Status, SaleStatus.VendaCriada)
                                .RuleFor(c => c.Products, _saleOrderItem.Generate(3)!);

        public static SaleOrder GenerateCartFaker()
        {
            return _saleOrderFaker.Generate();
        }

    }
}

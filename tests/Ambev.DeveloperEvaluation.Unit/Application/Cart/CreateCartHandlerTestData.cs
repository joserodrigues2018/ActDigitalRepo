using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Application
{
    public static class CreateCartHandlerTestData
    {
        private static readonly Faker<CreateCartItemCommand> _createCartItem = new Faker<CreateCartItemCommand>()
            .RuleFor(i => i.ProductId, f => f.Random.Guid().ToString())
            .RuleFor(i => i.Quantity, f => f.Random.Number(1,20));

        private static readonly Faker<CreateCartCommand> _createCartHandlerFaker = new Faker<CreateCartCommand>()
            .RuleFor(c => c.UserId,f => f.Random.Guid().ToString())
            .RuleFor(c => c.Client, f => f.Company.CompanyName())
            .RuleFor(c => c.CartDate, DateTime.Now)
            .RuleFor(c => c.Filial, f => f.Company.CompanySuffix().ToString())
            .RuleFor(c => c.CartItens, _createCartItem.Generate(10)!);

        public static CreateCartCommand GenerateCartFaker()
        {
            return _createCartHandlerFaker.Generate();
        }

    }
}

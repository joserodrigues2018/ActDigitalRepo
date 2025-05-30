using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreatetSaleRequestValidator: AbstractValidator<CreateSaleResquest>
    {
        public CreatetSaleRequestValidator()
        {
            RuleFor(sale => sale.CartId).NotEmpty().WithMessage("CartId is required");
            RuleFor(sale => sale.Client).NotNull().WithMessage("Client is requiride");
            RuleFor(sale => sale.Filial).NotNull().WithMessage("Filial is requiride");

            RuleForEach(sale => sale.Products).ChildRules(item =>
            {
                item.RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId is required");
                item.RuleFor(x => x.Quantity < 0).NotNull().WithMessage("Quanmtity is negative");
                item.RuleFor(x => x.Quantity).NotNull().NotEqual(0).WithMessage("Qunatity is required");
                item.RuleFor(x => x.Quantity).NotNull().GreaterThanOrEqualTo(1).LessThanOrEqualTo(20)
                                             .WithMessage("Maximum limit: 20 items per product");
                item.RuleFor(x => x.UnitPrice).NotNull().NotEqual(0).WithMessage("UnitPrice is required");

            });


        }
    }
}

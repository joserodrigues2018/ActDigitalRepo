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

        }
    }
}

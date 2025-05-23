using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// CreateSaleCommandValidator
    /// </summary>
    public class CreateSaleCommandValidator: AbstractValidator<CreateSaleCommand>
    {
        public CreateSaleCommandValidator()
        {
            RuleFor(sale => sale.CartId).NotEmpty().WithMessage("CartId is required");
            RuleFor(sale => sale.Client).NotNull().WithMessage("Client is requiride");
            RuleFor(sale => sale.Filial).NotNull().WithMessage("Filial is requiride");
        }
    }
}

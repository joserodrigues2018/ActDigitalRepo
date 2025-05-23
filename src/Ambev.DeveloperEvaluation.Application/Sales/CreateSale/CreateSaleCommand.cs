using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// CreateSaleCommand
    /// </summary>
    public class CreateSaleCommand: IRequest<CreateSaleResult>
    {
        public Guid CartId { get; set; }
        public string? Client { get; set; }
        public string? Filial { get; set; }

        public IList<CreateSaleItemCommand>? SaleOrderItems { get; set; }

        public ValidationResultDetail Validate()
        {
            var validator = new CreateSaleCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}

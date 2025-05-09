
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    /// <summary>
    /// CreateCartCommand
    /// </summary>
    public class CreateCartCommand: IRequest<CreateCartResult>
    {
        public string? UserId { get; set; }
        public DateTime DateRegistro { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }

        public ValidationResultDetail Validate()
        {
            var validator = new CreateCartCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}

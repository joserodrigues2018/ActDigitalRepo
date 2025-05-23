using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    /// <summary>
    /// CreateCartCommand
    /// </summary>
    public class CreateCartCommand: IRequest<CreateCartResult>
    {
        public string? UserId { get; set; }
        public DateTime CartDate { get; set; }

        public IList<CreateCartItemCommand>? Products { get; set; }

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

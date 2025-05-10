using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartResult
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime DateRegistro { get; set; }
    }
}

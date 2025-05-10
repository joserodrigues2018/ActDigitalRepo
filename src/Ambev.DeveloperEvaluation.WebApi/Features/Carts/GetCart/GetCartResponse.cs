using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart
{
    public class GetCartResponse
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime DateRegistro { get; set; }
    }
}

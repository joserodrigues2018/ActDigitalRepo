using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartResult
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public int NumeroVenda { get; set; }
        public string? Client { get; set; }
        public DateTime CartDate { get; set; }
        public decimal ValueTotal { get; set; }
        public string? Filial { get; set; }
        public CartStatus StatusCart { get; set; }

        public IList<GetCartItemResult>? CartItems { get; set; } = [];
    }
}

using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public  class Cart: BaseEntity
    {
        public string? UserId { get; set; }
        public int NumeroVenda { get; set; }
        public string? Client { get; set; }
        public DateTime CartDate { get; set; }
        public decimal ValueTotal { get; set; }
        public string? Filial { get; set; }
        public CartStatus StatusCart { get; set; }

        public IList<CartItem>? CartItens { get; set; }

        public Cart()
        {
            CartDate = DateTime.UtcNow;
        }
    }
}

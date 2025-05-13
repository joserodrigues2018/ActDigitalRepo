using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public  class Cart: BaseEntity
    {
        public string? UserId { get; set; }
        public string? Client { get; set; }
        public DateTime CartDate { get; set; }
        public decimal ValueTotal { get; set; }
        public string? Filial { get; set; }
        public string? StatusCart { get; set; }

        public IList<CartItem>? CartItens { get; set; }

        public Cart()
        {
            CartDate = DateTime.UtcNow;
        }
    }
}

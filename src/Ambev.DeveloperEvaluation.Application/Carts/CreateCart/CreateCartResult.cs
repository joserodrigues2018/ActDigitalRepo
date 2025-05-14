using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartResult
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public int NumeroVenda { get; set; }
        public string? Client { get; set; }
        public DateTime CartDate { get; set; }
        public decimal ValueTotal { get; set; }
        public string? Filial { get; set; }
        public CartStatus StatusCart { get; set; }

        public IList<CreateCartItemResult>? CartItems { get; set; }  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartItemResult
    {
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ValueTotIten { get; set; }
        public int Discount { get; set; }
        public string? StatusIten { get; set; }
    }
}

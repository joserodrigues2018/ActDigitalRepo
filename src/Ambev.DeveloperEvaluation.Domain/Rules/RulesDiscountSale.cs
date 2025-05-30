using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Domain.Rules
{
    public class RulesDiscountSale : IRulesDiscountSale
    {
        public async Task<SaleOrderItem> DiscountSale(SaleOrderItem saleItem, CancellationToken cancellationToken)
        {
            if (saleItem.Quantity >= 4 && saleItem.Quantity <= 9)
            {
                saleItem.PercentDiscount = 10;
            }
            else if (saleItem.Quantity >= 10 && saleItem.Quantity <= 20)
            {
                saleItem.PercentDiscount = 20;
            }
            else
            {
                saleItem.PercentDiscount = 0;
            }

            saleItem.ValueTotIten = await ApplyDiscount(saleItem.UnitPrice, saleItem.Quantity, saleItem.PercentDiscount);


            return saleItem;
        }

        public static Task<decimal> ApplyDiscount(decimal unitPrice, int quantItem, int percent)
        {
            return Task.FromResult(percent == 0 ? (quantItem * unitPrice) : (quantItem * unitPrice) - (quantItem * unitPrice * percent) / 100);
        }
    }
}

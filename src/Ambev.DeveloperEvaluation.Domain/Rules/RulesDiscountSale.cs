using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Domain.Rules
{
    public class RulesDiscountSale : IRulesDiscountSale
    {
        public SaleOrder DiscountSale(SaleOrder sale, CancellationToken cancellationToken)
        {
            foreach (var item in sale!.Products!)
            {
                if (item.Quantity >= 4 && item.Quantity <= 9)
                {
                    item.PercentDiscount = 10;
                }
                else if (item.Quantity >= 10 && item.Quantity <= 20)
                {
                    item.PercentDiscount = 20;
                }
                else
                {
                    item.PercentDiscount = 0;
                }

                item.ValueTotIten = item.PercentDiscount == 0 ? (item.Quantity * item.UnitPrice) 
                                                                : (item.Quantity * item.UnitPrice) 
                                                                - (item.Quantity * item.UnitPrice * item.PercentDiscount) / 100;


                sale.ValueTotal += item.ValueTotIten;
            }

            sale.NumeroVenda = new Random().Next();
            sale.Status = SaleStatus.VendaCriada;


            return sale;
        }
    }
}

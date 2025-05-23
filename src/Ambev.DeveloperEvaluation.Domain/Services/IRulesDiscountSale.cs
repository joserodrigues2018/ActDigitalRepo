using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public interface IRulesDiscountSale
    {
        Task<SaleOrderItem> DiscountSale(SaleOrderItem cartitem, CancellationToken cancellationToken);
    }
}

using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public interface IRulesDiscountSale
    {
        SaleOrder DiscountSale(SaleOrder sale, CancellationToken cancellationToken);
    }
}

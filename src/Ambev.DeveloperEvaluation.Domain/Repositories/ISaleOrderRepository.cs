using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleOrderRepository
    {
        /// <summary>
        /// Add SaleOrder with percent discount for sale
        /// </summary>
        /// <param name="sale"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<SaleOrder> AddSaleOrder(SaleOrder sale, CancellationToken cancellationToken = default);

        /// <summary>
        ///  return Sale registre
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<SaleOrder?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    }
}

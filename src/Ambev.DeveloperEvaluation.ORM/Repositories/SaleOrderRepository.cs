using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class SaleOrderRepository : ISaleOrderRepository
    {
        private DefaultContext _context;

        public SaleOrderRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<SaleOrder> AddSaleOrder(SaleOrder sale, CancellationToken cancellationToken = default)
        {
            await _context.SaleOrders.Include( s => s.SaleOrderItems).ToListAsync(cancellationToken);

            await _context.SaleOrders.AddRangeAsync(sale);

            await _context.SaveChangesAsync(cancellationToken);

            return sale;

        }
    }
}

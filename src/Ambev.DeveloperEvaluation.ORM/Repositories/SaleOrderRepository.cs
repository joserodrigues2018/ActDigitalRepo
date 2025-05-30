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
            await _context.SaleOrders.Include( s => s.Products).ToListAsync(cancellationToken);

            await _context.SaleOrders.AddRangeAsync(sale);

            await _context.SaveChangesAsync(cancellationToken);

            return sale;

        }

        public async Task<SaleOrder?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _context.SaleOrders.Include( c => c.Products ).ToListAsync(cancellationToken);

            return await _context.SaleOrders.FirstOrDefaultAsync( p => p.Id == id, cancellationToken);
        }
    }
}

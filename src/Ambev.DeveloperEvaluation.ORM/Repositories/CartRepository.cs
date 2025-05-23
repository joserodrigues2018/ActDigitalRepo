using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly DefaultContext _context;

        public CartRepository(DefaultContext context)
        {
            _context = context;       
        }

        public async Task<Cart?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _context.Carts.Include(c => c.Products).ToListAsync(cancellationToken);

            return await _context.Carts.FirstOrDefaultAsync(c => c.Id == id);
        }

        {
            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}

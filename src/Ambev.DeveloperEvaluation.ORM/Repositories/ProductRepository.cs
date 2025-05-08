using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DefaultContext _context;

        public ProductRepository(DefaultContext context)
        {
            _context = context;       
        }
        public Task<User> CreateAsync(Product product, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}

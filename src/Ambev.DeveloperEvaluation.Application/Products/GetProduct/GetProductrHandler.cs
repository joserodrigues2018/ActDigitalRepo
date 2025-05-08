using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct
{
    public class GetProductrHandler: IRequestHandler<GetProductrCommand, GetProductrResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductrHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<GetProductrResult> Handle(GetProductrCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

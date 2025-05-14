using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartHandler: IRequestHandler<GetCartCommand, GetCartResult>
    {
        private readonly ICartRepository _CartRepository;
        private readonly IMapper _mapper;

        public GetCartHandler(ICartRepository CartRepository, IMapper mapper)
        {
            _CartRepository = CartRepository;
            _mapper = mapper;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        public async Task<GetCartResult> Handle(GetCartCommand request, CancellationToken cancellationToken)
        {
            var validator = new GetCartValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var cart = await _CartRepository.GetByIdAsync(request.Id, cancellationToken);
            if (cart == null)
                throw new KeyNotFoundException($"Cart with ID {request.Id} not found");
        
            var result = _mapper.Map<GetCartResult>(cart);

            foreach (var item in cart!.CartItens!)
            {
                var resulItitem = new GetCartItemResult()
                {
                    Id = item.Id,
                    CartId = item.CartId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    ValueTotIten = item.ValueTotIten,
                    Discount = item.Discount,
                    StatusIten = item.StatusIten
                };

                result.CartItems!.Add(resulItitem);
            }

            return result;
        }
    }
}

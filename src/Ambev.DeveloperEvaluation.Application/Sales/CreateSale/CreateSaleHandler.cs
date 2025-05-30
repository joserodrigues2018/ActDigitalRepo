using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleHandler: IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly IRulesDiscountSale _rulesDiscountSale;
        private readonly ISaleOrderRepository _saleRepository;
        private readonly IMapper _mapper;

        public CreateSaleHandler(ISaleOrderRepository saleRepository, IMapper mapper, 
                                 ICartRepository cartRepository, 
                                 IRulesDiscountSale rulesDiscountSale,
                                 IProductRepository productRepository)
        {
            
            _mapper = mapper;
            _saleRepository = saleRepository;
            _rulesDiscountSale = rulesDiscountSale;
        }
        /// <summary>
        /// Handles the CreateSaleCommand request
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException"></exception>
        public async Task<CreateSaleResult> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateSaleCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var sale = _mapper.Map<SaleOrder>(command);

            var saleOrder = _rulesDiscountSale.DiscountSale(sale, cancellationToken);

            var createSale = await _saleRepository.AddSaleOrder(saleOrder, cancellationToken);

            var result = _mapper.Map<CreateSaleResult>(createSale);

            return result;
        }
    }
}

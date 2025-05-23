using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleHandler: IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly ICartRepository _cartRepository;
        private readonly ISaleOrderRepository _saleRepository;
        private readonly IMapper _mapper;

        public CreateSaleHandler(ISaleOrderRepository saleRepository, IMapper mapper, ICartRepository cartRepository)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
            _cartRepository = cartRepository;
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

            var cart = _cartRepository.GetByIdAsync(command.CartId);

            var sale = _mapper.Map<SaleOrder>(command);

            var createSale = await _saleRepository.AddSaleOrder(sale, cancellationToken);

            var result = _mapper.Map<CreateSaleResult>(createSale);

            return result;
        }
    }
}

using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Services;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleHandler: IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly IRulesDiscountSale _rulesDiscountSale;
        private readonly ICartRepository _cartRepository;
        private readonly ISaleOrderRepository _saleRepository;
        private readonly IMapper _mapper;

        public CreateSaleHandler(ISaleOrderRepository saleRepository, IMapper mapper, 
                                 ICartRepository cartRepository, 
                                 IRulesDiscountSale rulesDiscountSale,
                                 IProductRepository productRepository)
        {
            
            _mapper = mapper;
            _cartRepository = cartRepository;
            _saleRepository = saleRepository;
            _rulesDiscountSale = rulesDiscountSale;
            _productRepository = productRepository;
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

            var cart = await _cartRepository.GetByIdAsync(command.CartId);

            foreach (var item in cart!.Products!)
            {
                var CommandCartProducts = new CreateSaleItemCommand()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };

                command!.SaleOrderItems!.Add(CommandCartProducts);
            }

            var sale = _mapper.Map<SaleOrder>(command);

            foreach (var itemSale in sale!.SaleOrderItems!)
            {
                var product = await _productRepository.GetByIdAsync(Guid.Parse(itemSale!.ProductId!), cancellationToken);

                if (product != null)
                {
                    itemSale.UnitPrice = product.Price;

                    var saleItem = await _rulesDiscountSale.DiscountSale(itemSale, cancellationToken);

                    sale.ValueTotal += saleItem.ValueTotIten;
                }
            }

            sale.NumeroVenda = new Random().Next();
            sale.Status = SaleStatus.VendaCriada;

            var createSale = await _saleRepository.AddSaleOrder(sale, cancellationToken);

            var result = _mapper.Map<CreateSaleResult>(createSale);

            return result;
        }
    }
}

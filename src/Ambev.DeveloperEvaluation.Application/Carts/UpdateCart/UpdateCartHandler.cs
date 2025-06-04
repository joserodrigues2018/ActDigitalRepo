using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart;

public class UpdateCartHandler : IRequestHandler<UpdateCartCommand, UpdateCartResult>
{
    private readonly ICartRepository _cartRepository;
    private readonly ICartItenRepository _cartItenRepository;
    private readonly IMapper _mapper;

    public UpdateCartHandler(ICartRepository cartRepository, IMapper mapper, ICartItenRepository cartItenRepository)
    {
        _cartRepository = cartRepository;
        _cartItenRepository = cartItenRepository;
        _mapper = mapper;
    }

    public async Task<UpdateCartResult> Handle(UpdateCartCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdateCartCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var existingCart = await _cartRepository.GetByIdAsync(command.Id, cancellationToken) ?? throw new InvalidOperationException($"Cart with Id {command.Id} not exists");

        await _cartItenRepository.DeleteAync([.. existingCart!.Products!], cancellationToken);

        foreach (var item in existingCart.Products)
        {
            existingCart.Products.Remove(item);
        }

        var listCartItems = new List<CartItem>();

        foreach (var cartItem in command!.Products!)
        {
            existingCart!.Products.Add(new CartItem()
            {
                CartId = command.Id,
                ProductId = cartItem.ProductId,
                Quantity = cartItem.Quantity,
            });
        };

        existingCart.UserId = command.UserId;

        var updatedCart = await _cartRepository.UpdateAsync(existingCart, cancellationToken);

        var result = _mapper.Map<UpdateCartResult>(updatedCart);

        return result;
    }
}

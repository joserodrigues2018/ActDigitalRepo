using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, UpdateProductResult>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public UpdateProductHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdateProductCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var existingProduct = await _productRepository.GetByIdAsync(command.Id, cancellationToken) ?? throw new InvalidOperationException($"Product with Id {command.Id} not exists");

        existingProduct.Title = command!.Title!;
        existingProduct.Description = command!.Description!;
        existingProduct.Category = command!.Category!;
        existingProduct.Price = command.Price;
        existingProduct.Image = command!.Image!;

        var updatedUser = await _productRepository.UpdateAsync(existingProduct, cancellationToken);
        var result = _mapper.Map<UpdateProductResult>(updatedUser);

        return result;
    }
}

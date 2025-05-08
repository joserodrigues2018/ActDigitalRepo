using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct
{
    public class GetProductrCommand: IRequest<GetProductrResult>
    {
        public Guid Id { get; }

        public GetProductrCommand(Guid id)
        {
            Id = id;
        }
    }
}

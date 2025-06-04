using Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    public class UpdateProductProfile:Profile
    {
        public UpdateProductProfile()
        {
            CreateMap<UpdateProductResquest, UpdateProductCommand>();
            CreateMap<UpdateProductResult, UpdateProductResponse>();
        }

    }
}

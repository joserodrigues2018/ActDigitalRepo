using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings.Products
{
    public class GetProducResponseProfile: Profile
    {
        public GetProducResponseProfile()
        {
            CreateMap<GetProductResult, GetProductResponse>();
        }
    }
}

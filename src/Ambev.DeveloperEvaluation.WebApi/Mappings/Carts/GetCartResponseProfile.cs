using Ambev.DeveloperEvaluation.Application.Carts.GetCart;
using Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings.Carts
{
    public class GetProducResponseProfile: Profile
    {
        public GetProducResponseProfile()
        {
            CreateMap<GetCartResult, GetCartResponse>();
        }
    }
}

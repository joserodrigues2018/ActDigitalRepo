using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleProfile:Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleResquest, CreateSaleCommand>();
            CreateMap<CreateSaleResult, CreateSaleResponse>();
            CreateMap<CreateSaleItemResult, CreateSaleItemResponse>();
        }

    }
}

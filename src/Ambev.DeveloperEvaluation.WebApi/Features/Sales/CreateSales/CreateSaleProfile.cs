using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleProfile:Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleResquest, CreateSaleCommand>();
            CreateMap<CreateSaleItemRequest, CreateSaleItemCommand>();   
            CreateMap<CreateSaleResult, CreateSaleResponse>();
            CreateMap<CreateSaleItemResult, CreateSaleItemResponse>();
        }

    }
}

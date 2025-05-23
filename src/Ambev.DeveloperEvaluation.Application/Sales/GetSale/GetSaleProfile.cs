using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    public class GetSaleProfile: Profile
    {
        public GetSaleProfile()
        {
            CreateMap<SaleOrder, GetSaleResult>();
            CreateMap<SaleOrderItem, GetSaleItemResult>();
        }
    }
}

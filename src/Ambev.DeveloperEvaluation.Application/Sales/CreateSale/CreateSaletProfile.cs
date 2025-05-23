using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System.Linq;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleProfile: Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleCommand, SaleOrder>();
            CreateMap<CreateSaleItemCommand, SaleOrderItem>();

            CreateMap<SaleOrder, CreateSaleResult>();
            CreateMap<SaleOrderItem, CreateSaleItemResult>();

        }
    }
}

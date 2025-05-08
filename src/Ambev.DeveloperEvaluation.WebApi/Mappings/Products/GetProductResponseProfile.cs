﻿using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings.Products
{
    public class GetProductResponseProfile: Profile
    {
        public GetProductResponseProfile()
        {
            CreateMap<GetProductResult, GetProductResponse>();
        }
    }
}

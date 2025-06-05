using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    public class UpdateProductIdRequest
    {
        [FromRoute]
        public Guid Id { get; set; }

        [FromBody]

        public UpdateProductResquest? Request { get; set; }
    }
}

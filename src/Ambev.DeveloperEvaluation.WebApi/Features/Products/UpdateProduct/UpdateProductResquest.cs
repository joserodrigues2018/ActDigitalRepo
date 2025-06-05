namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    public class UpdateProductResquest
    {
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; } 
        public string? Category { get; set; }
        public string? Image { get; set; }
    }
}

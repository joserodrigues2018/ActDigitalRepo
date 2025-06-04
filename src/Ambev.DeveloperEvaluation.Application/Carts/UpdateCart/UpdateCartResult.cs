namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart;

public class UpdateCartResult
{
    public Guid Id { get; set; }
    public string? UserId { get; set; }
    public DateTime CartDate { get; set; }

    public IList<UpdateCartItemResult>? Products { get; set; }

}

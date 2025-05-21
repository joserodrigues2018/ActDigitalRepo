namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public interface ICalcDiscount
    {
       Task<decimal> ApplyDiscount(decimal unitPrice, int quantity, int percent);
    }
}

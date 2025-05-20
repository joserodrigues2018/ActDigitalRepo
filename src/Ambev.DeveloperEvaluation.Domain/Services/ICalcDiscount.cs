namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public  interface ICalcDiscount
    {
        public decimal ApplyDiscount(decimal unitPrice, int quantity, int percent);
    }
}

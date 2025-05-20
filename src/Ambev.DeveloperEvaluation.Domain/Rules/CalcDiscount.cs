using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Domain.Rules
{
    public class CalcDiscount : ICalcDiscount
    {
        public decimal ApplyDiscount(decimal unitPrice, int quantItem, int percent)
        {
            return (quantItem * unitPrice * percent) / 100;
        }
    }
}

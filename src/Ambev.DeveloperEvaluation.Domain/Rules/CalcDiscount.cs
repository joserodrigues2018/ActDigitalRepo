using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Domain.Rules
{
    public class CalcDiscount : ICalcDiscount
    {
        public Task<decimal> ApplyDiscount(decimal unitPrice, int quantItem, int percent)
        {
            return Task.FromResult(percent == 0 ? (quantItem * unitPrice) : (quantItem * unitPrice) - (quantItem * unitPrice * percent) / 100);
        }
    }
}

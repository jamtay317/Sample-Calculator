using SampleCalculator.Core.Expressions;

namespace SampleCalculator.Core.Calculators
{
    public interface ICalculator
    {
        double Evaluate(Expression expression);
    }
}
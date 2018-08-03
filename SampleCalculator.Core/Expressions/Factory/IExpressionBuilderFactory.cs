using SampleCalculator.Core.Expressions.Builder;

namespace SampleCalculator.Core.Expressions.Factory
{
    public interface IExpressionBuilderFactory
    {
        IExpressionBuilder GetBuilder(string symbol);
    }
}
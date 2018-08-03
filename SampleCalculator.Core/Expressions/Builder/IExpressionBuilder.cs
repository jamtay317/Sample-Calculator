namespace SampleCalculator.Core.Expressions.Builder
{
    public interface IExpressionBuilder
    {
        Expression Build(Expression expression, string symobl);
    }
}
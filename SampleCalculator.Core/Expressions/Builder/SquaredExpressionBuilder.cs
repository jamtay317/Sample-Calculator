namespace SampleCalculator.Core.Expressions.Builder
{
    public class SquaredExpressionBuilder:IExpressionBuilder
    {
        public Expression Build(Expression expression, string symobl)
        {
            return $"{Constants.Expressions.Exponent}({expression})^2";
        }
    }
}
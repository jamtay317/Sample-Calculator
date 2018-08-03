namespace SampleCalculator.Core.Expressions.Builder
{
    public class ScientificNotationExpressionBuilder:IExpressionBuilder
    {
        public Expression Build(Expression expression, string symobl)
        {
            expression = $"{Constants.Expressions.Exponent}(10)^{expression}";
            return expression;
        }
    }
}
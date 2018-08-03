namespace SampleCalculator.Core.Expressions.Builder
{
    public class ExpExpressionBuilder:IExpressionBuilder
    {
        public Expression Build(Expression expression, string symobl)
        {
            return $"{symobl}({expression})^2";
        }
    }
}
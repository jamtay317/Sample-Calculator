namespace SampleCalculator.Core.Expressions.Builder
{
    public class SinExpressionBuilder:IExpressionBuilder
    {
        public Expression Build(Expression expression, string symobl)
        {
            return $"{symobl}({expression})";
        }
    }
}

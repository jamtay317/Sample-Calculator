using SampleCalculator.Core.Expressions;

namespace SampleCalculator.Core.ExtensionMethods
{
    public static class ExpressionExtentionMethods
    {
        public static string RepaceExpressionName(this Expression expression)
        {
            return expression.ToString().Replace(expression.ExpressionType, string.Empty);
        }
    }
}
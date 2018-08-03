using System;
using System.Linq;

namespace SampleCalculator.Core.Expressions.Builder
{
    public class BasicExpressionBuilder:IExpressionBuilder
    {
        public Expression Build(Expression expression, string symbol)
        {
            var expressionLabel= Constants.Expressions.ExpressionNames.First(x => x.Equals(symbol, StringComparison.CurrentCultureIgnoreCase));
            expression = $"{expressionLabel}({expression})";

            return expression;
        }
    }
}
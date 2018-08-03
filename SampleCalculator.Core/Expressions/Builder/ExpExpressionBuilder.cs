﻿namespace SampleCalculator.Core.Expressions.Builder
{
    public class ExpExpressionBuilder:IExpressionBuilder
    {
        public Expression Build(Expression expression, string symobl)
        {
            Expression e = $"{Constants.Expressions.Exponent}({expression})^";
            return e;

        }
    }
}
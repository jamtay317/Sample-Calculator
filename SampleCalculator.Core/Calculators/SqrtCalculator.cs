using System;
using SampleCalculator.Core.Expressions;

namespace SampleCalculator.Core.Calculators
{
    public class SqrtCalculator:BasicCalculator
    {
        public override double Evaluate(Expression expression)
        {
            var e = expression.ToString().Replace(Constants.Expressions.Sqrt, string.Empty);
            var innerValue = base.Evaluate(e);
            return Math.Sqrt(innerValue);
        }
    }
}
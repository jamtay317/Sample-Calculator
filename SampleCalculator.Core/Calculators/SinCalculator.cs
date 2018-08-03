using System;
using SampleCalculator.Core.Expressions;
using SampleCalculator.Core.ExtensionMethods;

namespace SampleCalculator.Core.Calculators
{
    public class SinCalculator:BasicCalculator
    {
        public override double Evaluate(Expression expression)
        {
            var e = expression.RepaceExpressionName();
            var innerValue = base.Evaluate(e);

            return Math.Sin(innerValue*Math.PI/180);
        }
    }
}

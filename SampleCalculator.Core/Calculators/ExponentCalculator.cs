using System;
using SampleCalculator.Core.Expressions;
using SampleCalculator.Core.ExtensionMethods;

namespace SampleCalculator.Core.Calculators
{
    public class ExponentCalculator:BasicCalculator
    {
        public override double Evaluate(Expression expression)
        {
            var e = expression.RepaceExpressionName();
            var powerIndex = expression.Value.IndexOf("^") + 1;
            e = e.Substring(0, powerIndex - 1 - Constants.Expressions.Exponent.Length);

            var power = int.Parse(expression.Value.Substring(powerIndex));

            var innerValue = base.Evaluate(e);

            return Math.Pow(innerValue, power);
        }
    }
}

using System.Globalization;
using SampleCalculator.Core.Calculators;

namespace SampleCalculator.Core.Expressions.Parsers
{
    public abstract class ParserBase:IParser
    {
        protected ParserBase(ICalculator calculator)
        {
            Calculator = calculator;
        }
        public virtual Expression Parse(Expression e)
        {
            return Calculator.Evaluate(e).ToString(CultureInfo.InvariantCulture);
        }

        protected ICalculator Calculator { get; set; }
    }
}
using SampleCalculator.Core.Calculators;

namespace SampleCalculator.Core.Expressions.Parsers
{
    public class SqrtParser:ParserBase
    {
        public SqrtParser() : base(new BasicCalculator())
        {
        }
    }
}
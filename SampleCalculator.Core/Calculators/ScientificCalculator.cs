using System;
using SampleCalculator.Core.Expressions;
using SampleCalculator.Core.Expressions.Parsers;
using SampleCalculator.Core.Expressions.Tokenizers;

namespace SampleCalculator.Core.Calculators
{
    public class ScientificCalculator:BasicCalculator
    {
        private ITokenizer _tokenizer;
        private IParser _parser;

        public ScientificCalculator()
        {
            _tokenizer = new SqrtTokenizer();
            _parser = new SqrtParser();
        }

        public override double Evaluate(Expression expression)
        {
            var token = _tokenizer.GetToken(expression);
            var parserValue = _parser.Parse(token);
            var value = Convert.ToDouble(parserValue.Value);
            return value;
        }
    }
}
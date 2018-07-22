namespace SampleCalculator.Core.Expressions.Tokenizers
{
    public class BasicTokenizer:TokenizerBase
    {
        public override ITokenizer Sucessor { get; } = null;
        protected override bool ContainsToken(Expression expression)
        {
            return true;
        }

        protected override Expression SplitToken(Expression e)
        {
            return e;
        }
    }
}
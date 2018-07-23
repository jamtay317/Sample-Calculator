namespace SampleCalculator.Core.Expressions.Tokenizers
{
    public class BasicTokenizer:TokenizerBase
    {
        public override string ExpressionName { get; } = null;
        public override ITokenizer Sucessor { get; protected set; } = null;
        protected override bool IsDefault => true;

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
namespace SampleCalculator.Core.Expressions.Tokenizers
{
    public class SqrtTokenizer:TokenizerBase
    {
        
        public override ITokenizer Sucessor { get; } = new BasicTokenizer();

        public Expression GetToken(Expression expression)
        {
            throw new System.NotImplementedException();
        }

        protected override bool ContainsToken(Expression expression)
        {
            return expression.ToString().Contains(Constants.Expressions.Sqrt);
        }

        protected override Expression SplitToken(Expression e)
        {
            throw new System.NotImplementedException();
        }
    }
}
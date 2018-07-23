namespace SampleCalculator.Core.Expressions.Tokenizers
{
    public class SqrtTokenizer:TokenizerBase
    {
        public SqrtTokenizer():base(){}

        public SqrtTokenizer(ITokenizer successor):this()
        {
            Sucessor = successor;
        }
        public override string ExpressionName => Constants.Expressions.Sqrt;
        public override ITokenizer Sucessor { get; protected set; }
        
        protected override bool ContainsToken(Expression expression)
        {
            return expression.ToString().Contains(Constants.Expressions.Sqrt);
        }

        
    }
}
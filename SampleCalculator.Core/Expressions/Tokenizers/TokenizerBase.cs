namespace SampleCalculator.Core.Expressions.Tokenizers
{
    public abstract class TokenizerBase: ITokenizer
    {
        public abstract ITokenizer Sucessor { get; }
        public virtual Expression GetToken(Expression expression)
        {
            if (!ContainsToken(expression))
            {
                return Sucessor.GetToken(expression);
            }

            return SplitToken(expression);
        }

        protected abstract bool ContainsToken(Expression expression);

        protected abstract Expression SplitToken(Expression e);

        protected virtual (int startIndex, int length)  GetParenthesesIndexs(Expression e, int startIndex)
        {
            var counter = 1;
            var currentIndex = startIndex;

            while (counter>0)
            {
                if (e.ToString().Substring(currentIndex++,1) == ")")
                {
                    counter--;
                    currentIndex--;
                }
            }

            return (startIndex, currentIndex-startIndex+1);
        }
    }
}
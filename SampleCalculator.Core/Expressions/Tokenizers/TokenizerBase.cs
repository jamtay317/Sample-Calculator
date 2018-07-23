using System;

namespace SampleCalculator.Core.Expressions.Tokenizers
{
    public abstract class TokenizerBase: ITokenizer
    {
        protected TokenizerBase()
        {
            if (!IsDefault)
            {
                Sucessor = Sucessor ?? new BasicTokenizer();
            }
        }

        protected virtual bool IsDefault => false;
        public abstract string ExpressionName { get; }
        public abstract ITokenizer Sucessor { get; protected set; }
        public virtual Expression GetToken(Expression expression)
        {
            if (!ContainsToken(expression))
            {
                return Sucessor.GetToken(expression);
            }

            return SplitToken(expression);
        }

        protected abstract bool ContainsToken(Expression expression);

        protected virtual Expression SplitToken(Expression e)
        {
            var startIndex = e.ToString().IndexOf(ExpressionName, StringComparison.Ordinal) + ExpressionName.Length;
            var indexes = GetParenthesesIndexs(e, startIndex);
            return new Expression(e.ToString().Substring(indexes.startIndex, indexes.length));
        }

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
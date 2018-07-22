namespace SampleCalculator.Core.Expressions.Tokenizers
{
    public interface ITokenizer
    {
        ITokenizer Sucessor { get; }

        Expression GetToken(Expression expression);
    }
}
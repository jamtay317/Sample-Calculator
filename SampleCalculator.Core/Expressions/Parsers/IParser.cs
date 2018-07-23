namespace SampleCalculator.Core.Expressions.Parsers
{
    public interface IParser
    {
        Expression Parse(Expression e);
    }
}
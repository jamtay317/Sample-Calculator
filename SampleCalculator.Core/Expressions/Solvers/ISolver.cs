using SampleCalculator.Core.Calculators;

namespace SampleCalculator.Core.Expressions.Solvers
{
    public interface ISolver
    {
        Expression Solve(Expression expression);

        ICalculator Calculator { get; }

        bool CanSolve(Expression expression);
    }
}
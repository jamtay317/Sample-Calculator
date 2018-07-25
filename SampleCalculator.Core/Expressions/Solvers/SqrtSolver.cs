using SampleCalculator.Core.Calculators;

namespace SampleCalculator.Core.Expressions.Solvers
{
    public class SqrtSolver:BasicSolver
    {
        public SqrtSolver()
        {
            Calculator = new SqrtCalculator();
        }

        public override bool CanSolve(Expression expression)
        {
            return expression.ToString().Contains(Constants.Expressions.Sqrt);
        }
    }
}
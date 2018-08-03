using SampleCalculator.Core.Calculators;

namespace SampleCalculator.Core.Expressions.Solvers
{
    public class SinSolver:BasicSolver
    {
        public SinSolver()
        {
            Calculator = new SinCalculator();
        }
        public override bool CanSolve(Expression expression)
        {
            return expression.ToString().Contains(Constants.Expressions.Sin);
        }

    }
}
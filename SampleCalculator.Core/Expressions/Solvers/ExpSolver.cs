using SampleCalculator.Core.Calculators;

namespace SampleCalculator.Core.Expressions.Solvers
{
    public class ExpSolver:BasicSolver
    {
        public ExpSolver()
        {
            Calculator = new ExponentCalculator();
        }

        public override bool CanSolve(Expression expression)
        {
            return expression.ToString().Contains(Constants.Expressions.Exponent);
        }

    }
}

using System.Globalization;
using SampleCalculator.Core.Calculators;

namespace SampleCalculator.Core.Expressions.Solvers
{
    public class BasicSolver:ISolver
    {
        public Expression Solve(Expression expression)
        {
            if (!CanSolve(expression)) return expression;

            return Calculator.Evaluate(expression).ToString(CultureInfo.CurrentCulture);
        }

        public ICalculator Calculator { get; protected set; } = new BasicCalculator();
        public virtual bool CanSolve(Expression expression)
        {
            return true;
        }
    }
}

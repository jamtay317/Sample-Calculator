using System;
using SampleCalculator.Core.Expressions;
using SampleCalculator.Core.Expressions.Solvers;

namespace SampleCalculator.Core.Calculators
{
    public class ScientificCalculator:BasicCalculator
    {
        

        public override double Evaluate(Expression expression)
        {
            var solvers = new AllSolvers();
            foreach (var allSolver in solvers)
            {
                expression = allSolver.Solve(expression);
            }

            return Convert.ToDouble(expression.ToString());
        }
    }
}
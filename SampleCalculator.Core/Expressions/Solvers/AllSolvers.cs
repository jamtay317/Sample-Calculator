using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace SampleCalculator.Core.Expressions.Solvers
{
    public class AllSolvers:Collection<ISolver>
    {
        public AllSolvers():this(Constants.Expressions.ExpressionNames)
        {
            
        }

        public AllSolvers(params string[] solverNamesInRunOrder)
        {
            LoadSolvers(solverNamesInRunOrder);
        }

        private void LoadSolvers(string[] solverNamesInRunOrder)
        {
            var solverTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => !x.IsAbstract)
                .Where(x => x.IsClass)
                .Where(x => typeof(ISolver).IsAssignableFrom(x))
                .ToList();

            foreach (var orderType in solverNamesInRunOrder)
            {
                var solverType = solverTypes.SingleOrDefault(x => x.Name == $"{orderType}Solver");
                if (solverType != null && Activator.CreateInstance(solverType) is ISolver solver)
                {
                    Add(solver);
                }
            }
        }
    }
}
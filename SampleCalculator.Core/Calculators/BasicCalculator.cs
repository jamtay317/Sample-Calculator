using System;
using System.Data;
using SampleCalculator.Core.Expressions;

namespace SampleCalculator.Core.Calculators
{
    public class BasicCalculator:ICalculator
    {
        public virtual double Evaluate(Expression expression)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(expression.ToString(), "");

            //dataTable.Compute returns Infinity if you devide by zero
            if (value.ToString() == "∞")
            {
                throw new DivideByZeroException($"Please check your expression, you are dividing by zero. your current expression is: {expression}");
            }

            return Convert.ToDouble(value);
        }
    }
}
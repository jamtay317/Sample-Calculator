using System;
using System.Data;

namespace SampleCalculator.Core.Calculators
{
    public class BasicCalculator:ICalculator
    {
        public double Evaluate(string expression)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(expression, "");

            //dataTable.Compute returns Infinity if you devide by zero
            if (value.ToString() == "∞")
            {
                throw new DivideByZeroException($"Please check your expression, you are dividing by zero. your current expression is: {expression}");
            }

            return Convert.ToDouble(value);
        }
    }
}
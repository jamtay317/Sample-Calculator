using SampleCalculator.Core.Calculators;
using SampleCalculator.ViewsModule.ViewModels.Bases;

namespace SampleCalculator.ViewsModule.ViewModels
{
    public class BasicCalculatorViewModel:CalculatorViewModelBase
    {
        public BasicCalculatorViewModel() : base(new BasicCalculator())
        {
        }

        protected override string NumberFormat => "N2";
    }
}
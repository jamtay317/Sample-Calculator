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
        public override int Height { get; set; } = 400;
        public override int Width { get; set; } = 300;
    }
}
using SampleCalculator.Core.Calculators;
using SampleCalculator.ViewsModule.ViewModels.Bases;

namespace SampleCalculator.ViewsModule.ViewModels
{
    public class ScientificCalculatorViewModel:CalculatorViewModelBase
    {
        public ScientificCalculatorViewModel() : base(new ScientificCalculator())
        {
        }

        protected override string NumberFormat => "N4";
        public override int Height { get; set; } = 500;
        public override int Width { get; set; } = 500;
    }
}
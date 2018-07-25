using System;
using System.Linq;
using Prism.Commands;
using SampleCalculator.Core.Calculators;
using SampleCalculator.Core.Constants;
using SampleCalculator.Core.Expressions;
using SampleCalculator.ViewsModule.ViewModels.Bases;

namespace SampleCalculator.ViewsModule.ViewModels
{
    public class ScientificCalculatorViewModel:CalculatorViewModelBase
    {
        public ScientificCalculatorViewModel() : base(new ScientificCalculator())
        {
        }

        protected override string NumberFormat => "N4";
        public override int Height { get; set; } = 550;
        public override int Width { get; set; } = 550;

        public DelegateCommand<string> SymbolButtonPushedCommand { get; set; }

        public override void RegisterCommands()
        {
            base.RegisterCommands();
            SymbolButtonPushedCommand = new DelegateCommand<string>(SymbolButtonPushedExecute);
        }

        private void SymbolButtonPushedExecute(string symbol)
        {
            var expression = Expressions.ExpressionNames.First(x=>x.Equals(symbol,StringComparison.CurrentCultureIgnoreCase));
            Expression = $"{expression}({Expression})";
        }

    }
}
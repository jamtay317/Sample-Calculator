using System;
using Prism.Commands;
using SampleCalculator.Core.Calculators;

namespace SampleCalculator.ViewsModule.ViewModels.Bases
{
    public abstract class CalculatorViewModelBase:ViewModelBase, ICalculatorViewModelBase
    {
        private bool _shouldResetExpression;

        protected CalculatorViewModelBase(ICalculator calculator)
        {
            Calculator = calculator;
        }

        private string _expression;
        public string Expression
        {
            get => _expression;
            set => SetProperty(ref _expression, value);
        }

        public DelegateCommand<string> ButtonPushedCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }

        protected abstract string NumberFormat { get; }
        public abstract int Height { get; set; }
        public abstract int Width { get; set; }
        
        protected ICalculator Calculator { get; private set; }

        public override void RegisterCommands()
        {
            ButtonPushedCommand = new DelegateCommand<string>(ButtonPushedExecute);
            EqualsCommand = new DelegateCommand(EqualsExecute);
        }

        private void EqualsExecute()
        {
            var expressionValue = Calculator.Evaluate(Expression);
            Expression = expressionValue.ToString(NumberFormat);
            _shouldResetExpression = true;
        }

        protected virtual void ButtonPushedExecute(string buttonContent)
        {
            if (_shouldResetExpression)
            {
                Expression = String.Empty;
                _shouldResetExpression = false;
            }
            Expression += buttonContent;
        }
    }
}
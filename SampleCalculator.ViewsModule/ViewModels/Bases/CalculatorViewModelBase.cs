using System;
using Prism.Commands;
using SampleCalculator.Core.Calculators;
using SampleCalculator.Core.Expressions;

namespace SampleCalculator.ViewsModule.ViewModels.Bases
{
    public abstract class CalculatorViewModelBase:ViewModelBase, ICalculatorViewModelBase
    {
        private bool _shouldResetExpression;

        protected CalculatorViewModelBase(ICalculator calculator)
        {
            Calculator = calculator;
        }

        private Expression _expression;
        public Expression Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                RaisePropertyChanged();
            }
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
using Prism.Commands;
using SampleCalculator.Core.Expressions;

namespace SampleCalculator.ViewsModule.ViewModels.Bases
{
    public interface ICalculatorViewModelBase
    {
        Expression Expression { get; }

        DelegateCommand<string> ButtonPushedCommand { get; set; }

        DelegateCommand EqualsCommand { get; set; }

        int Height { get; set; }

        int Width { get; set; }
    }
}
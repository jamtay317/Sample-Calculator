using Prism.Commands;

namespace SampleCalculator.ViewsModule.ViewModels.Bases
{
    public interface ICalculatorViewModelBase
    {
        string Expression { get; }

        DelegateCommand<string> ButtonPushedCommand { get; set; }

        DelegateCommand EqualsCommand { get; set; }

        int Height { get; set; }

        int Width { get; set; }
    }
}
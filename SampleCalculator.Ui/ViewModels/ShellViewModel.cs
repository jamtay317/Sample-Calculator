using Prism.Mvvm;
using SampleCalculator.ViewsModule.ViewModels.Bases;
using SampleCalculator.ViewsModule.ViewModels.Factories;

namespace SampleCalculator.Ui.ViewModels
{
    public class ShellViewModel:BindableBase
    {
        private readonly ICalculatorViewModelFactory _calculatorViewModelFactory;

        public ShellViewModel(ICalculatorViewModelFactory calculatorViewModelFactory)
        {
            _calculatorViewModelFactory = calculatorViewModelFactory;
            ViewModel = _calculatorViewModelFactory.GetCalculatorViewModel();
        }

        private string _title = "Awesome Calculator";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private ICalculatorViewModelBase _viewModel;
        public ICalculatorViewModelBase ViewModel
        {
            get => _viewModel;
            set => SetProperty(ref _viewModel, value);
        }
    }
}

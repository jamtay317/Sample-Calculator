using Prism.Commands;
using Prism.Mvvm;
using SampleCalculator.Ui.Models;
using SampleCalculator.ViewsModule.ViewModels.Bases;
using SampleCalculator.ViewsModule.ViewModels.Factories;

namespace SampleCalculator.Ui.ViewModels
{
    public class ShellViewModel:ViewModelBase
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

        public Flyouts Flyouts { get; set; } = new Flyouts();

        public DelegateCommand OpenLeftFlyoutCommand { get; set; }

        public override void RegisterCommands()
        {
            OpenLeftFlyoutCommand = new DelegateCommand(OpenLeftFlyoutExecute);
        }

        private void OpenLeftFlyoutExecute()
        {
            Flyouts.LeftIsOpen = true;
        }
    }
}

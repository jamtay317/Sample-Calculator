using System.Linq;
using Prism.Commands;
using Prism.Mvvm;
using SampleCalculator.Core.Constants;
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
            SelectedViewModel = Core.Constants.ViewModels.All.First(x => x.DisplayName == "Basic");
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

        private ViewModel _selectedViewModel;
        public ViewModel SelectedViewModel
        {
            get => _selectedViewModel;
            set => SetProperty(ref _selectedViewModel, value);
        }

        public Flyouts Flyouts { get; set; } = new Flyouts();

        public DelegateCommand OpenLeftFlyoutCommand { get; set; }
        public DelegateCommand ViewModelChangedCommand { get; set; }

        public override void RegisterCommands()
        {
            OpenLeftFlyoutCommand = new DelegateCommand(OpenLeftFlyoutExecute);
            ViewModelChangedCommand = new DelegateCommand(ViewModelChangedExecute);
        }

        private void ViewModelChangedExecute()
        {
            ViewModel = _calculatorViewModelFactory.GetCalculatorViewModel(SelectedViewModel.ViewModelName);
        }

        private void OpenLeftFlyoutExecute()
        {
            Flyouts.LeftIsOpen = true;
        }
    }
}

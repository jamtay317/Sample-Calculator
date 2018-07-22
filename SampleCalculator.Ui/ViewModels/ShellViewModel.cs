using Prism.Mvvm;
using SampleCalculator.ViewsModule.ViewModels;
using SampleCalculator.ViewsModule.ViewModels.Bases;

namespace SampleCalculator.Ui.ViewModels
{
    public class ShellViewModel:BindableBase
    {

        public ShellViewModel()
        {
            ViewModel = new BasicCalculatorViewModel();
        }

        private string _title = "Awesome Calculator";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private CalculatorViewModelBase _viewModel;
        public CalculatorViewModelBase ViewModel
        {
            get => _viewModel;
            set => SetProperty(ref _viewModel, value);
        }
    }
}

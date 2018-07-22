using Prism.Mvvm;

namespace SampleCalculator.Ui.ViewModels
{
    public class ShellViewModel:BindableBase
    {
        private string _title = "Awesome Calculator";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}

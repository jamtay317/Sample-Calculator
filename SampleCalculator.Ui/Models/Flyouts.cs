using Prism.Mvvm;

namespace SampleCalculator.Ui.Models
{
    public class Flyouts:BindableBase
    {
        private bool _leftIsOpen;
        public bool LeftIsOpen
        {
            get => _leftIsOpen;
            set => SetProperty(ref _leftIsOpen, value);
        }

        private bool _bottomIsOpen;
        public bool BottomIsOpen
        {
            get => _bottomIsOpen;
            set => SetProperty(ref _bottomIsOpen, value);
        }
    }
}
namespace SampleCalculator.Core.Constants
{
    public static class ViewModels
    {
        public static ViewModel[] All = new []
        {
            new ViewModel("Basic", "Basic"),
            new ViewModel("Scientific","Scientific")
        };
    }

    public class ViewModel
    {
        public ViewModel(string displayName, string viewModelName)
        {
            DisplayName = displayName;
            ViewModelName = viewModelName;
        }

        public string DisplayName { get; }

        public string ViewModelName { get; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
    
}
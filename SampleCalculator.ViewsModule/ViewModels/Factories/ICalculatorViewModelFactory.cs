using SampleCalculator.ViewsModule.ViewModels.Bases;

namespace SampleCalculator.ViewsModule.ViewModels.Factories
{
    public interface ICalculatorViewModelFactory
    {
        /// <summary>
        /// Creates a new instance of the requested ViewModel if one doesnt already exist, if it does, it returns same instance as before.
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        ICalculatorViewModelBase GetCalculatorViewModel(string calculatorName = "default");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SampleCalculator.Core.ContainerHelpers;
using SampleCalculator.ViewsModule.ViewModels.Bases;

namespace SampleCalculator.ViewsModule.ViewModels.Factories
{
    public class CalculatorViewModelFactory:ICalculatorViewModelFactory
    {
        private readonly IContainerHelper _containerHelper;
        private readonly Dictionary<string, ICalculatorViewModelBase> _calculatorViewModels = new Dictionary<string, ICalculatorViewModelBase>();

        public CalculatorViewModelFactory(IContainerHelper containerHelper)
        {
            _containerHelper = containerHelper;
            var defaultCalculator = _containerHelper.Resolve<BasicCalculatorViewModel>();
            _calculatorViewModels.Add("default", defaultCalculator);
            _calculatorViewModels.Add("Basic", defaultCalculator);
        }

        public ICalculatorViewModelBase GetCalculatorViewModel(string calculatorName = "default")
        {
            ICalculatorViewModelBase calculatorViewModel = null;
            if (!_calculatorViewModels.ContainsKey(calculatorName))
            {
                var type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x=>x.Name == $"{calculatorName}CalculatorViewModel");

                if (_containerHelper.Resolve(type) is ICalculatorViewModelBase viewModel)
                {
                    _calculatorViewModels.Add(calculatorName, viewModel);
                }
                else
                {
                    throw new NullReferenceException($"{calculatorName}CalculatorViewModel was not found in the assembly, please check and try again" );
                }
            }

            calculatorViewModel = _calculatorViewModels[calculatorName];
            return calculatorViewModel;
        }
    }
}
using Microsoft.Practices.Unity;
using SampleCalculator.Core.ContainerHelpers;
using SampleCalculator.ViewsModule.ViewModels.Factories;

namespace SampleCalculator.Ui
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterSingletons(this IUnityContainer container)
        {
            container.RegisterType<IContainerHelper, ContainerHelper>();
            container.RegisterType<ICalculatorViewModelFactory, CalculatorViewModelFactory>();
            return container;
        }

        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            return container;
        }
    }
}
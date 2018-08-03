using Microsoft.Practices.Unity;
using SampleCalculator.Core.ContainerHelpers;
using SampleCalculator.Core.Expressions.Factory;
using SampleCalculator.ViewsModule.ViewModels.Factories;

namespace SampleCalculator.Ui
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterSingletons(this IUnityContainer container)
        {
            container.RegisterType<IContainerHelper, ContainerHelper>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICalculatorViewModelFactory, CalculatorViewModelFactory>(new ContainerControlledLifetimeManager());
            container.RegisterType<IExpressionBuilderFactory, ExpressionBuilderFactory>(new ContainerControlledLifetimeManager());
            return container;
        }

        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            return container;
        }
    }
}
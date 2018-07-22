using Microsoft.Practices.Unity;

namespace SampleCalculator.Ui
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterSingletons(this IUnityContainer container)
        {
            return container;
        }

        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            return container;
        }
    }
}
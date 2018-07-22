using System;
using Microsoft.Practices.Unity;

namespace SampleCalculator.Core.ContainerHelpers
{
    public class ContainerHelper:IContainerHelper
    {
        private readonly IUnityContainer _container;

        public ContainerHelper(IUnityContainer container)
        {
            _container = container;
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}
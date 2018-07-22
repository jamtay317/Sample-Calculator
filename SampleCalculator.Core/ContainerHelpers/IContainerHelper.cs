using System;

namespace SampleCalculator.Core.ContainerHelpers
{
    /// <summary>
    /// A Wrapper for UnityContainer to allow for unit testing with moq
    /// </summary>
    public interface IContainerHelper
    {
        /// <summary>
        /// Returns new instance of the type passed in
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Resolve<T>();

        /// <summary>
        /// Returns a instance of type passed in
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        object Resolve(Type type);
    }
}
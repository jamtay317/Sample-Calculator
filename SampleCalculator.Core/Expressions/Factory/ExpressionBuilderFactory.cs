using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SampleCalculator.Core.ContainerHelpers;
using SampleCalculator.Core.Expressions.Builder;

namespace SampleCalculator.Core.Expressions.Factory
{
    public class ExpressionBuilderFactory:IExpressionBuilderFactory
    {
        private readonly IContainerHelper _containerHelper;
        private readonly Dictionary<string, Type> _expressionBuilderTypes = new Dictionary<string, Type>();

        public ExpressionBuilderFactory(IContainerHelper containerHelper)
        {
            _containerHelper = containerHelper;
            LoadExpressionBuilders();
        }

        public IExpressionBuilder GetBuilder(string symbol)
        {
            var builderName = $"{symbol}ExpressionBuilder";
            if (!_expressionBuilderTypes.ContainsKey(builderName))
                return new BasicExpressionBuilder();
            var type = _expressionBuilderTypes[builderName];

            IExpressionBuilder expressionBuilder = _containerHelper.Resolve(type) as IExpressionBuilder;

            return expressionBuilder;
        }

        private void LoadExpressionBuilders()
        {
            var expressionBuilderTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsClass)
                .Where(x => !x.IsAbstract)
                .Where(x => typeof(IExpressionBuilder).IsAssignableFrom(x))
                .ToList();

            foreach (var expressionBuilderType in expressionBuilderTypes)
            {
                _expressionBuilderTypes.Add(expressionBuilderType.Name, expressionBuilderType);
            }
        }
    }
}
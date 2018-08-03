using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleCalculator.Core.Expressions;
using SampleCalculator.Core.Expressions.Builder;
using SampleCalculator.Core.Expressions.Factory;
using SampleCalculator.ViewsModule.ViewModels;

namespace SampleCalculator.ViewsModuleTests.ViewModels
{
    [TestClass]
    public class ScientificCalculatorViewModelTests
    {
        private ScientificCalculatorViewModel _scientificCalculatorViewModel;
        private Mock<IExpressionBuilderFactory> _expressionBuilderFactoryMock;
        private Mock<IExpressionBuilder> _expressionBuilderFactory;

        public ScientificCalculatorViewModelTests()
        {
            _expressionBuilderFactoryMock = new Mock<IExpressionBuilderFactory>();
            _expressionBuilderFactory = new Mock<IExpressionBuilder>();
            _expressionBuilderFactoryMock.Setup(x => x.GetBuilder("Sqrt")).Returns(_expressionBuilderFactory.Object);
            _scientificCalculatorViewModel = new ScientificCalculatorViewModel(_expressionBuilderFactoryMock.Object);
        }

        [TestMethod]
        public void SymbolPushedCommand_Exressions_ShouldWrapCurrentExpressionInPerenthesis()
        {
            //Arrange

            _expressionBuilderFactory.Setup(x => x.Build(It.IsAny<Expression>(), "Sqrt")).Returns("Sqrt(3*3)");
            _scientificCalculatorViewModel.Expression = "3*3";

            //Act
            _scientificCalculatorViewModel.SymbolButtonPushedCommand.Execute("Sqrt");

            //Assert
            Assert.AreEqual("Sqrt(3*3)", _scientificCalculatorViewModel.Expression);
        }
    }
}

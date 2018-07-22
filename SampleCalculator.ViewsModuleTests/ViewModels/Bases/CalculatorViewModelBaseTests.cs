using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleCalculator.Core.Calculators;
using SampleCalculator.ViewsModule.ViewModels.Bases;

namespace SampleCalculator.ViewsModuleTests.ViewModels.Bases
{
    [TestClass]
    public class CalculatorViewModelBaseTests
    {
        private TestCalculatorViewModel _calculatorViewModel;
        private Mock<ICalculator> _calculatorMock;

        [TestInitialize]
        public void Init()
        {
            _calculatorMock = new Mock<ICalculator>();
            _calculatorViewModel = new TestCalculatorViewModel(_calculatorMock.Object);
        }

        [TestMethod]
        public void ButtonPushCommand_StringContentPassed_ShouldAppendToExpression()
        {
            //Act
            _calculatorViewModel.ButtonPushedCommand.Execute("a");
            _calculatorViewModel.ButtonPushedCommand.Execute("b");

            //Assert
            Assert.AreEqual("ab", _calculatorViewModel.Expression);
        }

        [TestMethod]
        public void EqualsCommand__ShouldChangeExpressionToCorrectValue()
        {
            //Arrange
            _calculatorMock.Setup(x => x.Evaluate("3+3")).Returns(6d);
            _calculatorViewModel.Expression = "3+3";

            //Act
            _calculatorViewModel.EqualsCommand.Execute();

            //Assert
            Assert.AreEqual("6.0",_calculatorViewModel.Expression);
        }

        [TestMethod]
        public void ButtonPushCommand_AfterEqulsCommandWasExecuted_ShouldResetExpressionWithNewValue()
        {
            //Arrange
            _calculatorMock.Setup(x => x.Evaluate("3+3")).Returns(6d);
            _calculatorViewModel.Expression = "3+3";

            //Act
            _calculatorViewModel.EqualsCommand.Execute();
            Assert.AreEqual("6.0", _calculatorViewModel.Expression);

            _calculatorViewModel.ButtonPushedCommand.Execute("5");
            _calculatorViewModel.ButtonPushedCommand.Execute("5");

            //Assert
            Assert.AreEqual("55", _calculatorViewModel.Expression);
        }
    }

    public class TestCalculatorViewModel:CalculatorViewModelBase
    {

        public TestCalculatorViewModel(ICalculator calculator):base(calculator)
        {
            
        }
        //Test class to test abstract class
        protected override string NumberFormat => "N1";
    }
}
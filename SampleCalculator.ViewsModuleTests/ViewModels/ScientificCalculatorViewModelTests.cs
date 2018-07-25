using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator.ViewsModule.ViewModels;

namespace SampleCalculator.ViewsModuleTests.ViewModels
{
    [TestClass]
    public class ScientificCalculatorViewModelTests
    {
        private ScientificCalculatorViewModel _scientificCalculatorViewModel;

        public ScientificCalculatorViewModelTests()
        {
            _scientificCalculatorViewModel = new ScientificCalculatorViewModel();
        }

        [TestMethod]
        public void SymbolPushedCommand_Exressions_ShouldWrapCurrentExpressionInPerenthesis()
        {
            //Arrange
            _scientificCalculatorViewModel.Expression = "3*3";

            //Act
            _scientificCalculatorViewModel.SymbolButtonPushedCommand.Execute("Sqrt");

            //Assert
            Assert.AreEqual("Sqrt(3*3)", _scientificCalculatorViewModel.Expression);
        }
    }
}

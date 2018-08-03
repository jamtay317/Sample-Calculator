using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator.Core.Calculators;
using SampleCalculator.Core.Constants;
using SampleCalculator.Core.Expressions;

namespace SampleCalculator.CoreTests.Calculators
{
    [TestClass]
    public class ScientificCalculatorTests
    {
        private ScientificCalculator _scientificCalculator;

        [TestInitialize]
        public void Init()
        {
            _scientificCalculator = new ScientificCalculator();
        }

        [TestMethod]
        public void Evaulate_PassBasicMathIn_ShouldReturnCorrectValue()
        {
            //Arrange
            Expression expression = "3+3";

            //Act
            var value = _scientificCalculator.Evaluate(expression);

            //Assert
            Assert.AreEqual(6d,value);
        }

        [TestMethod]
        public void Evaulate_PassSqrtIn_ShouldReturnCorrectValue()
        {
            //Arrange
            Expression expression = "Sqrt(9)";

            //Act
            var value = _scientificCalculator.Evaluate(expression);

            //Assert
            Assert.AreEqual(3d,value);
        }
    }
}

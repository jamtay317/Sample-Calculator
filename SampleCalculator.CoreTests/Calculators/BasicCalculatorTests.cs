using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator.Core.Calculators;

namespace SampleCalculator.CoreTests.Calculators
{
    [TestClass]
    public class BasicCalculatorTests
    {
        private BasicCalculator _calculator;

        [TestInitialize]
        public void Init()
        {
            _calculator = new BasicCalculator();
        }

        [TestMethod]
        public void Evaluate_Addition_ShouldReturnCorrectValueAsDouble()
        {
            //Arrange
            var expression = "3+3";

            //Act
            var value = _calculator.Evaluate(expression);


            //Assert
            Assert.AreEqual(6d,value);
        }

        [TestMethod]
        public void Evaluate_Multiplication_ShouldReturnCorrectValue()
        {
            //Arrange
            var expresson = "3*3";

            //Act
            var value = _calculator.Evaluate(expresson);

            //Assert
            Assert.AreEqual(9d,value);
        }

        [TestMethod]
        public void Evaluate_Subtraction_ShouldReturnCorrectValue()
        {
            //Arrange
            var expression = "3-3";

            //Act
            var value = _calculator.Evaluate(expression);

            //Assert
            Assert.AreEqual(0d, value);
        }

        [TestMethod]
        public void Evaluate_Division_ShouldReturnCorrectValue()
        {
            //Arrange
            var expression = "3/3";

            //Act
            var value = _calculator.Evaluate(expression);

            //Assert
            Assert.AreEqual(1d,value);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Evaluate_Division_ShouldThrowExceptionIfDivideByZero()
        {
            //Arrange
            var expression = "3/0";

            //Act
            var value = _calculator.Evaluate(expression);

            //Assert
        }
    }
}
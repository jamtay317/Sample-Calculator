using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator.Core.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCalculator.Core.Expressions;

namespace SampleCalculator.Core.Calculators.Tests
{
    [TestClass()]
    public class ExponentCalculatorTests
    {
        private Expression _expression;
        private ExponentCalculator _calculator;

        [TestInitialize]
        public void Init()
        {
            _expression = $"{Constants.Expressions.Exponent}(3+3)^2";
            _calculator = new ExponentCalculator();
        }

        [TestMethod]
        public void Evlaulate_ValidExpression_ShouldCalculateCorectly()
        {
            //Arrange
            var expectedValue = 36d;


            //Act
            var actualValue = _calculator.Evaluate(_expression);


            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }
        
    }
}
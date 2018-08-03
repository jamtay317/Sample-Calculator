using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator.Core.Constants;
using SampleCalculator.Core.Expressions;

namespace SampleCalculator.CoreTests.Structs
{
    [TestClass]
    public class ExpressionTests
    {
        private Expression _expression;

        [TestInitialize]
        public void Init()
        {
            _expression = new Expression("A");
        }

        [TestMethod]
        public void Value__ShouldEqualSameAsPassedIn()
        {
            
            //Assert
            Assert.AreEqual("A", _expression.Value);

        }

        [TestMethod]
        public void EqualsOperator_PassString_ShouldSetValue()
        {
            //Arrange
            var expresion = "3+3";
            _expression = expresion;

            
            //Assert
            Assert.AreEqual(expresion, _expression.Value);
        }

        [TestMethod]
        public void AddOpperator_PassNewValue_ShouldAppendText()
        {
            
            //Act
            _expression += "+B";

            //Assert
            Assert.AreEqual("A+B", _expression.Value);
        }

        [TestMethod]
        public void Equals_PassSameValueIn_ShouldEqualTrue()
        {
            //Arrange
            var e1 = new Expression("3+3");
            var e2 = new Expression("3+3");
            

            //Assert
            Assert.IsTrue(e1.Equals(e2));
        }

        [TestMethod]
        public void Equals_PassDifferentValueIn_ShouldEqualFalse()
        {
            //Arrange
            var e1 = new Expression("3+3");
            var e2 = new Expression("3+4");


            //Assert
            Assert.IsFalse(e1.Equals(e2));
        }

        [TestMethod]
        public void Create_NonBasicExpression_ShouldKnowExpressionType()
        {
            //Arrange
            Expression expresssion = "Sqrt(9)";
            
            //Assert
            Assert.AreEqual(Expressions.Sqrt, expresssion.ExpressionType);
        }
    }
}
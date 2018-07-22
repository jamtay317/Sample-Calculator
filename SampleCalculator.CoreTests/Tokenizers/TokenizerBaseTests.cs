using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleCalculator.Core.Constants;
using SampleCalculator.Core.Expressions;
using SampleCalculator.Core.Expressions.Tokenizers;

namespace SampleCalculator.CoreTests.Tokenizers
{
    [TestClass]
    public class TokenizerBaseTests:TokenizerBase
    {
        private Mock<ITokenizer> _sucessorTokenizer;
        private bool _containsToken = true;

        [TestInitialize]
        public void Init()
        {
            _sucessorTokenizer = new Mock<ITokenizer>();
            
        }

        public override ITokenizer Sucessor => _sucessorTokenizer.Object;
        protected override bool ContainsToken(Expression expression)
        {
            return _containsToken;
        }

        protected override Expression SplitToken(Expression e)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetPerenthesesIndexs_PassValidExpression_ShouldReturnCorrectValues()
        {
            //Arrange
            Expression expression = $"{Expressions.Sqrt}(3*3)+5";

            //Act
            var indexs = GetParenthesesIndexs(expression, 4);
            Expression newExpression = expression.ToString().Substring(indexs.startIndex, indexs.length);

            //Assert
            Assert.AreEqual("(3*3)", newExpression.ToString());

        }

        [TestMethod]
        public void GetToken_DoesntContainExpession_ShouldCallSucessorGetToken()
        {
            //Arrange
            _containsToken = false;

            //Act
            GetToken(new Expression("3+3"));

            //Assert
            _sucessorTokenizer.Verify(x=>x.GetToken(It.IsAny<Expression>()));
        }
    }
}
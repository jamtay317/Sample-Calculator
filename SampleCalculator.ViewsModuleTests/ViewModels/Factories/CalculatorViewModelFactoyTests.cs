using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleCalculator.Core.Calculators;
using SampleCalculator.Core.ContainerHelpers;
using SampleCalculator.Core.Expressions.Factory;
using SampleCalculator.ViewsModule.ViewModels;
using SampleCalculator.ViewsModule.ViewModels.Bases;
using SampleCalculator.ViewsModule.ViewModels.Factories;
using SampleCalculator.ViewsModuleTests.ViewModels.Bases;

namespace SampleCalculator.ViewsModuleTests.ViewModels.Factories
{
    [TestClass]
    public class CalculatorViewModelFactoyTests
    {
        private CalculatorViewModelFactory _factory;
        private Mock<IContainerHelper> _containerHelperMock;
        private Mock<ICalculator> _calculatorMock;
        private Mock<IExpressionBuilderFactory> _expressionBuilderFactoryMock;

        [TestInitialize]
        public void Init()
        {
            _containerHelperMock = new Mock<IContainerHelper>();
            _expressionBuilderFactoryMock = new Mock<IExpressionBuilderFactory>();

            _containerHelperMock.Setup(x => x.Resolve<BasicCalculatorViewModel>()).Returns(new BasicCalculatorViewModel());
            _containerHelperMock.Setup(x=>x.Resolve(typeof(ScientificCalculatorViewModel))).Returns(new ScientificCalculatorViewModel(_expressionBuilderFactoryMock.Object));

            _factory = new CalculatorViewModelFactory(_containerHelperMock.Object);
        }

        [TestMethod]
        public void GetCalculatorViewModel_NoParameter_ShouldReturnBasicFactory()
        {
            //Act
            var calc = _factory.GetCalculatorViewModel();

            //Assert
            Assert.IsTrue(calc is BasicCalculatorViewModel);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetCalculatorViewModel_BadName_ShouldThorwExcelption()
        {
            
            //Act
            var calc = _factory.GetCalculatorViewModel("uy");

            //Assert
        }

        [TestMethod]
        public void GetCalculatorViewModel_Scientific_ShouldReturnNewInstanceOfScientificCaclulator()
        {
           
            //Act
            var calc = _factory.GetCalculatorViewModel("Scientific");

            //Assert
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        public void GetCalculatorViewModel_Scientific_ShouldReturnSameInstanceOfCaclulator()
        {

            //Act
            var calc = (ScientificCalculatorViewModel)_factory.GetCalculatorViewModel("Scientific");
            calc.Expression = "A";


            var calc2 = _factory.GetCalculatorViewModel("Scientific");
            //Assert
            Assert.AreEqual(calc2.Expression,calc.Expression);
        }
    }

}
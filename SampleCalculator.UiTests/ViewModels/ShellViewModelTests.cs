using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleCalculator.Ui.ViewModels;
using SampleCalculator.ViewsModule.ViewModels.Factories;

namespace SampleCalculator.UiTests.ViewModels
{
    [TestClass]
    public class ShellViewModelTests
    {
        private ShellViewModel _viewModel;
        private Mock<ICalculatorViewModelFactory> _viewModelFactoryMock;

        [TestInitialize]
        public void Init()
        {
            _viewModelFactoryMock = new Mock<ICalculatorViewModelFactory>();
            _viewModel = new ShellViewModel(_viewModelFactoryMock.Object);
        }

        [TestMethod]
        public void OpenLeftFlyout_NoParameters_ShouldSetFlyoutsPropertyToTrue()
        {
            //Act
            _viewModel.OpenLeftFlyoutCommand.Execute();

            //Assert
            Assert.IsTrue(_viewModel.Flyouts.LeftIsOpen);
        }

        [TestMethod]
        public void OpenLeftFlyout_NoParameters_ShouldCallOnPropertyChanged()
        {
            //Arrange
            var fired = false;
            _viewModel.Flyouts.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(_viewModel.Flyouts.LeftIsOpen))
                {
                    fired = true;
                }
            };

            //Act
            _viewModel.OpenLeftFlyoutCommand.Execute();

            //Assert
            Assert.IsTrue(fired);
        }
    }
}
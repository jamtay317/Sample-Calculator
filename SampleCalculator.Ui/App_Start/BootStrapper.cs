using System.Windows;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace SampleCalculator.Ui
{
    public class Bootstrapper:UnityBootstrapper 
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Views.Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow?.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterSingletons().RegisterInstances();
        }
    }
}
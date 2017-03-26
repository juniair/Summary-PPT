using Microsoft.Practices.Unity;
using Prism.Unity;
using RegionAdapterApp.Views;
using System.Windows;

namespace RegionAdapterApp
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}

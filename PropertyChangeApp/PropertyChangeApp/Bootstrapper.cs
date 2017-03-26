using Microsoft.Practices.Unity;
using Prism.Unity;
using PropertyChangeApp.Views;
using System.Windows;

namespace PropertyChangeApp
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

using Microsoft.Practices.Unity;
using Prism.Unity;
using BindableApp.Views;
using System.Windows;

namespace BindableApp
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

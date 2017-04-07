using Microsoft.Practices.Unity;
using Prism.Unity;
using PaserApp.Views;
using System.Windows;
using Prism.Modularity;
using ButtonDisplay;
using JsonDisplay;
using XmlDisplay;

namespace PaserApp
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

        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();
            catalog.AddModule(typeof(ButtonDisplayModule));
            catalog.AddModule(typeof(JsonDisplayModule));
            catalog.AddModule(typeof(XmlDisplayModule));
            return catalog;
        }
    }
}

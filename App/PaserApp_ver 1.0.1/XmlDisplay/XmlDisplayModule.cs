using Prism.Modularity;
using Prism.Regions;
using System;
using XmlDisplay.Views;

namespace XmlDisplay
{
    public class XmlDisplayModule : IModule
    {
        IRegionManager _regionManager;

        public XmlDisplayModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("XmlDataRegion", typeof(XmlView));
        }
    }
}
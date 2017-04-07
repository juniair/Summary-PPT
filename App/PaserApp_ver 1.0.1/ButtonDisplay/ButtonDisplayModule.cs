using ButtonDisplay.Views;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace ButtonDisplay
{
    public class ButtonDisplayModule : IModule
    {
        IRegionManager _regionManager;

        public ButtonDisplayModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ButtonRegion", typeof(ButtonView));
        }
    }
}
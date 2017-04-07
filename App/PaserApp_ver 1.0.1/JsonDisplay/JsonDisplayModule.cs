using JsonDisplay.Views;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace JsonDisplay
{
    public class JsonDisplayModule : IModule
    {
        IRegionManager _regionManager;

        public JsonDisplayModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("JsonDataRegion", typeof(JsonView));
        }
    }
}
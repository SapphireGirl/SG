using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;


namespace SG.Util
{
    public abstract class ModuleBase : IModule
    {

        protected IUnityContainer Container { get; private set; }
        protected IRegionManager RegionManager { get; private set; }

        public ModuleBase(IUnityContainer container, IRegionManager regionManager)
        {
            Container = container;
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterTypes();
            RegisterViewsWithRegionAndResolveVM();
        }

        protected abstract void RegisterTypes();
        protected abstract void RegisterViewsWithRegionAndResolveVM();
    }
}

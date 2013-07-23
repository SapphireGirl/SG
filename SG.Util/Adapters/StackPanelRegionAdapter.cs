using System;
using System.Collections.Specialized;
using Microsoft.Practices.Prism.Regions;
using System.Windows.Controls;
using System.Windows;
using Microsoft.Practices.Unity;


namespace SG.Util
{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {
        #region Properties
        private IUnityContainer _container;
        private ISGLogger _logger;
        #endregion

        #region Constructors
        public StackPanelRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory, IUnityContainer container)
            : base(regionBehaviorFactory)
        {
            _container = container;
            _logger = _container.Resolve<ISGLogger>();
        }
        #endregion
        #region Methods

        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            if (region == null)
            {

                _logger.WriteToLog("StackPanelRegionAdapter: Adapt: region is Null");
                throw new ArgumentNullException("region");
            }
            if (regionTarget == null)
            {
                _logger.WriteToLog("StackPanelRegionAdapter: Adapt: regionTarget is Null");
                throw new ArgumentNullException("regionTarget");

            }

            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (FrameworkElement element in e.NewItems)
                    {
                        regionTarget.Children.Add(element);
                    }
                }
                else
                {
                    if (e.Action == NotifyCollectionChangedAction.Remove)
                    {
                        foreach (FrameworkElement element in e.NewItems)
                        {
                            regionTarget.Children.Remove(element);
                        }
                    }
                }
            };
        }


        #endregion
    }
}

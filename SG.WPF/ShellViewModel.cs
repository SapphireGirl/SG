using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using SG.Util;

namespace SG.WPF
{
     public class ShellViewModel : ViewModelBase, IShellViewModel
     {
         private readonly IRegionManager _regionManager;

         public DelegateCommand<object> GoToPriceShopCommand { get; private set; }

         public ShellViewModel(IRegionManager regionManager)
         {
             _regionManager = regionManager;

            
             GoToPriceShopCommand = new DelegateCommand<object>(NavigateToPriceShop);
             SGCommands.GoToPriceShopCommand.RegisterCommand(GoToPriceShopCommand);

         }

         // TODO: To swap out content region on the fly
         private void NavigateToPriceShop(object navigatePath)
         {
             if (navigatePath != null)
             {
                 _regionManager.RequestNavigate(RegionNames.ContentRegion, navigatePath.ToString());
             }
         }

         private void NavigateComplete(NavigationResult nresult)
         {
             // TODO: Log THis
         }
     }
}

using Prism.Mvvm;
using Prism.Regions;
using PrismDemo.Views;

namespace PrismDemo.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public ShellViewModel(IRegionManager regionManager)
        { 
            regionManager.RegisterViewWithRegion("HeaderRegion", typeof(Header));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Home));
        }
    }
}
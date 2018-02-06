using System.ComponentModel;
using System.Linq;
using Template10.Common;
using Template10.Controls;
using Template10.Services.NavigationService;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Fancybits.Views
{
    public sealed partial class Shell : Page
    {
        public static Shell Instance { get; set; }
        public static HamburgerMenu HamburgerMenu => Instance.MyHamburgerMenu;
        //public INavigationService NavigationService = null;


        public Shell()
        {
            Instance = this;
            InitializeComponent();
        }

        public Shell(INavigationService navigationService) : this()
        {
            SetNavigationService(navigationService);
        }

        public void SetNavigationService(INavigationService navigationService)
        {
            MyHamburgerMenu.NavigationService = navigationService;
            //NavigationService = navigationService;
        }

        private void ChannelsTb_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            //NavigationService.Navigate(typeof(Views.MainPage), null);
        }
    }
}


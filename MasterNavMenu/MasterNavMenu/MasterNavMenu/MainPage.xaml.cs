using MasterNavMenu.MenuItems;
using MasterNavMenu.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterNavMenu
{
	public partial class MainPage : MasterDetailPage
	{
        /*
                                +++ REFERENCES ++
            https://xamarinhelp.com/masterdetailpage-navigation-menu-xamarin-forms/
            https://almirvuk.blogspot.com/2016/10/how-to-make-master-detail-page.html
        */



        public List<MasterPageItem> menuList { get; set; }

		public MainPage()
		{
			InitializeComponent();

            menuList = new List<MasterPageItem>();

            //Android icons
            var page1 = new MasterPageItem() { Title = "FastDelivery", Icon = "ic_local_shipping_black_24dp.png", TargetType = typeof(View1) };
            var page2 = new MasterPageItem() { Title = "Menus", Icon = "ic_restaurant_black_24dp.png", TargetType = typeof(View2) };
            var page3 = new MasterPageItem() { Title = "Free Pizza", Icon = "ic_local_pizza_black_24dp.png", TargetType = typeof(View3) };
            var page4 = new MasterPageItem() { Title = "Dining", Icon = "ic_local_dining_black_24dp.png", TargetType = typeof(View4) };
            var page5 = new MasterPageItem() { Title = "Parking", Icon = "ic_local_parking_black_24dp.png", TargetType = typeof(View1) };
            var page6 = new MasterPageItem() { Title = "Locate Us", Icon = "ic_my_location_black_24dp.png", TargetType = typeof(View2) };


            //Adding menu items to menu list
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);

            //Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            //Initial navigation, this can be used for our home page
            Detail=new NavigationPage((Page)Activator.CreateInstance(typeof(ViewMain)));

            this.BindingContext = new
            {
                Header = "Restaurant Foods",
                //image = "MenuBanner.png",
                Footer = "Welcome to hotel plaza"
            };
		}

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
	}
}

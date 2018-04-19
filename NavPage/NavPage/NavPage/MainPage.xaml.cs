using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavPage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void LoginEvent(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage(userNameEntry.Text));
        }

    }
}

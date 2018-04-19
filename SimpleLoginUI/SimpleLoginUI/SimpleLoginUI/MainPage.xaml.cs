using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleLoginUI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login successfull!", "OK");
        }
    }
}

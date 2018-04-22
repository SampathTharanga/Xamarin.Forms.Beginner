using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DisplayingPopups
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void btnClicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Messsage", "Do you wanna change color(SeaGreen)", "YES", "NO");
            if (response)
                this.BackgroundColor = Color.SeaGreen;
            else
                this.BackgroundColor = Color.White;
        }

    }
}

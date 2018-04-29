using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Images
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void btnImageo1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImagePage1());
        }

    }
}

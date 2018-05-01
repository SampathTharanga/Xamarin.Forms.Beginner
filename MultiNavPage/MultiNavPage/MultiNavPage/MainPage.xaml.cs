using MultiNavPage.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MultiNavPage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }

        /*
         REFERENCES:
         http://wpbest.net/page-navigation-with-xamarin-forms
        */

        //Pushing pages to the Navigation Stack
        async void ButtonPage1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        async void ButtonPage2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        async void ButtonPage3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        async void ButtonPage4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        async void ButtonPage5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
        async void ButtonPage6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page6());
        }

        async void ButtonPage7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page7());
        }
        async void ButtonPage8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page8());
        }

        async void ButtonPage9_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page9());
        }

        async void ButtonPage10_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page10());
        }

        async void ButtonPage11_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page9());
        }

        async void ButtonPage12_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page10());
        }
    }
}

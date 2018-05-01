using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DisplayActionSheet
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void ButtonAction_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Select Country", "Cancel", "", "India", "Australia", "USA", "UK", "SriLanka");
            if (action == "India")
                ActionDetails.Text = "Select country " + action;
            if (action == "Australia")
                ActionDetails.Text = "Select country " + action;
            if (action == "USA")
                ActionDetails.Text = "Select country " + action;
            if (action == "UK")
                ActionDetails.Text = "Select country " + action;
            if (action == "SriLanka")
                ActionDetails.Text = "Select country " + action;
        }

    }
}

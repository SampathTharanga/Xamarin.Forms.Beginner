using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Indicator
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public void GetData(object sender, EventArgs e)
        {
            CheckConnectivity();
            var url = "http://" + EnryUrl.Text;
            Browser.Source = url;
        }

        private void CheckConnectivity()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                //DisplayAlert("Message", "Internet connected!", "OK");
            }
            else
            {
                DisplayAlert("Message", "No internet connection!", "OK");
            }
        }

        private void Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;
            progress.IsRunning = false;
        }

        private void Browser_Navigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
            progress.IsRunning = true;
        }

    }
}

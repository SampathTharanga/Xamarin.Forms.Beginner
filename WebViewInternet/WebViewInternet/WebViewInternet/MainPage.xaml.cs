using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace WebViewInternet
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            CheckConnectivity();

        }



        protected void CheckConnectivity()
        {
            if (!CrossConnectivity.Current.IsConnected)
                lblCheck.Text = "Check for your connection!";
            else
                lblCheck.Text = "Connected!.";
        }
    }
}

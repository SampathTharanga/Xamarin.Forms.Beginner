using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PdfDownloder
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            /*
             * Upload pdf in to the Google Drive.
             * Right click on the pdf and click "Get shareable link" also copy it.
             * Past it in to the Notepad. like below link
             * https://drive.google.com/open?id=0B_yaG39hp99bNGhBTTNNTFRSSXhWWWNTS2NTQVpZNXVCU0gw
             * change above link like this
             * https://drive.google.com/uc?export=download&id=0B_yaG39hp99bNGhBTTNNTFRSSXhWWWNTS2NTQVpZNXVCU0gw
             * 
             */
            var url = "https://drive.google.com/open?id=0B_yaG39hp99bNGhBTTNNTFRSSXhWWWNTS2NTQVpZNXVCU0gw";
            Device.OpenUri(new Uri(url));
        }

    }
}

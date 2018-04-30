using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace BarcodeAndQR
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        /*
         Please refer this link about fix the error
         https://github.com/Redth/ZXing.Net.Mobile/issues/657
         https://www.bountysource.com/issues/52445554-system-nullreferenceexception

            ERROR FIX
            https://docs.microsoft.com/en-us/xamarin/cross-platform/troubleshooting/questions/nuget-package-downgrade
        */

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
              {
                  Device.BeginInvokeOnMainThread(async () =>
                  {
                      await Navigation.PopAsync();
                      mycode.Text = result.Text;
                  });
  
              };
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        
        public void LoadWeb(object sender, EventArgs e)
        {
            var url = "http://" + EntryUrl.Text;
            Browser.Source = url;
        }

    }
}

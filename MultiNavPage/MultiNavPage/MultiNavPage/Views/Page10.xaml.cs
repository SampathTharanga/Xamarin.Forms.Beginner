using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiNavPage.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page10 : ContentPage
	{
		public Page10 ()
		{
			InitializeComponent ();
		}

        async void Page10BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
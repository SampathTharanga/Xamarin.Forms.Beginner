using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage (string userName)
		{
			InitializeComponent ();
            appUserName.Text = "Hi " + userName + ". Welcome to Home Page!";

        }
	}
}
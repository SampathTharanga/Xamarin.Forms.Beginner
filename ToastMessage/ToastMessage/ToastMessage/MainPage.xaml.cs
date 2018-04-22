using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToastMessage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_LongClicked(object sender, EventArgs e)
        {
            var message = "This is a Long Toast Message!";
            DependencyService.Get<IMessage>().LongTime(message);
        }

        private void Button_ShortClicked(object sender, EventArgs e)
        {
            var message = "This is a Short Toast Message!";
            DependencyService.Get<IMessage>().ShortTime(message);
        }

    }
}

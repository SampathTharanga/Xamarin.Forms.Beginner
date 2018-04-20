using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewViewCell
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage (int id, string name, string address)
		{
			InitializeComponent ();

            IDEntry.Text = id.ToString();
            NameEntry.Text = name;
            AddressEntry.Text = address;
		}
	}
}
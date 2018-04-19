using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleListView
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            myList.ItemsSource = new List<string>
            {
                "Sampath", "Tharanga", "Kumara", "Prasanna", "Ahinsha", "Kumari", "Jayalath", "Asela", "Sameera", "Sajith"
            };
		}
	}
}

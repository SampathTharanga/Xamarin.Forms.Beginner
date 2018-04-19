using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDataBind
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            myList.ItemsSource = people;
		}

        public List<Data> people = new List<Data>()
        {
            new Data{Name="Sampath", Address="Mawanella"},
            new Data{Name="Tharanga", Address="Anuradhapura"},
            new Data{Name="Kumara", Address = "Mihintale"}
        };
	}
}

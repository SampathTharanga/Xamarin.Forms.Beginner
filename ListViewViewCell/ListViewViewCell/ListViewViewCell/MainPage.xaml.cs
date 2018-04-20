using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewViewCell
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
            new Data { Name = "Sampath Tharanga", Address = "Dehimaduwa, Mawanella", Id = 1},
            new Data { Name = "Kumara Sandaruwan", Address = "Dehiovita, Avissawella", Id = 2},
            new Data { Name = "Roshan Kumara", Address = "Dikwella, Matara", Id = 3 },
            new Data { Name = "Asela Ranathunga", Address = "Hadapangala, Horana", Id = 4 }
        };
	}
}

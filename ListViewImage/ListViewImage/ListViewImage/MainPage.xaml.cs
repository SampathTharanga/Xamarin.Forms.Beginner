using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewImage
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
                new Data{ Name = "Sampath Tharanga", Address = "C-73, Dehimaduwa, Mawanella", ContactPhoto = "image1.jpg"},
                new Data{ Name = "Asela Ranathunga", Address = "Rajapihilla Road, Kurunegala", ContactPhoto = "image2.jpg"},
                new Data{ Name = "Kura Pathirana", Address = "Panala Road, Panadura", ContactPhoto = "image3.jpg"},
                new Data{ Name = "Nirosha Chandrasena", Address = "Police Junction, Thambuttegama", ContactPhoto = "image4.jpg"},
                new Data{ Name = "Jayalath Perera", Address = "Payagala, Kalutara", ContactPhoto = "image5.jpg"}
        };
    }
}

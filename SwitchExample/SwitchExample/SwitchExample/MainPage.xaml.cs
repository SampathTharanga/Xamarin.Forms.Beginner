using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwitchExample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void switch2_Toggled(object sender, ToggledEventArgs e)
        {
            bool value = e.Value;
            sv2.Text = value.ToString();
        }   
    }
}

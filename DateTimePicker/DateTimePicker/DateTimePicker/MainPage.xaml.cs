using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DateTimePicker
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var date = dp.Date;
            var time = tp.Time;
            lblDetails.Text = string.Format("Date : {0} \nTime : {1}", date, time);
        }

    }
}

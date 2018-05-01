﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiNavPage.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page7 : ContentPage
	{
		public Page7 ()
		{
			InitializeComponent ();
		}

        async void Page7BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
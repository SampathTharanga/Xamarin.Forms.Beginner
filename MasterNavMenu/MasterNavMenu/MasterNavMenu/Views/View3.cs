using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterNavMenu.Views
{
	public class View3 : ContentPage
	{
		public View3 ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to View3" }
				}
			};
		}
	}
}
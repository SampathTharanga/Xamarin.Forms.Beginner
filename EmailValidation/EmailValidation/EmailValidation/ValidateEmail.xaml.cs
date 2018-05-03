using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmailValidation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ValidateEmail : ContentPage
	{
		public ValidateEmail ()
		{
			InitializeComponent ();
		}

        public void Button_Clicked(object sender, EventArgs e)
        {
            var email = EnterEmail.Text;
            var emailPttern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

            if (!string.IsNullOrWhiteSpace(email) && !(Regex.IsMatch(email, emailPttern)))
                LabelError.Text = "Email verification faild!";
            else
                LabelError.Text = "";
        }

    }
}
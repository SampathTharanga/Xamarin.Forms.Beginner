using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CustomizingMap
{
	public partial class App : Application
	{
        /*
         REFERENCES:
         https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/custom-renderer/map/customized-pin
         https://developer.xamarin.com/samples/xamarin-forms/CustomRenderers/Map/Pin/
         https://romannurik.github.io/AndroidAssetStudio/
         keytool.exe -list -v -keystore debug.keystore -alias androiddebugkey -storepass android -keypass android
             
         https://xamarinhelp.com/xamarin-forms-maps/
         https://xamarinhelp.com/google-maps-api-key-xamarin-android-app/
         */



        public static double ScreenHeight;
        public static double ScreenWidth;

        public App ()
		{
			InitializeComponent();

			MainPage = new MapPageCS();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

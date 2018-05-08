using System;

using Xamarin.Forms;

namespace AzureXamarinForm
{
	public class App : Application
	{
        /*
        REFERENCES:
        https://docs.microsoft.com/en-gb/azure/app-service-mobile/app-service-mobile-xamarin-forms-get-started
        https://www.c-sharpcorner.com/article/create-a-xamarin-forms-app-using-azure-mobile-services/
        https://blog.xamarin.com/getting-started-azure-mobile-apps-easy-tables/
        */


        public App ()
		{
			// The root page of your application
			MainPage = new TodoList();
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SplashScreen.Droid
{
    [Activity(Label = "SplashScreen", Icon = "@drawable/icon", Theme = "@style/splashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

/*
    REFERENCES: 
        http://codeworks.it/blog/?p=294
        https://xamarinhelp.com/creating-splash-screen-xamarin-forms/
        https://www.c-sharpcorner.com/article/creating-a-splash-screen-in-xamarin-forms/
*/
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(500); // Let's wait awhile.....
            StartActivity(typeof(MainActivity));
        }
    }
}

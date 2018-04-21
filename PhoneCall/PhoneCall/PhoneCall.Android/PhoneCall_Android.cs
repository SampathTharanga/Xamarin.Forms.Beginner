using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PhoneCall.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneCall_Android))]
namespace PhoneCall.Droid
{
    public class PhoneCall_Android : IPhoneCall
    {
        public void makeCall(string phoneNumber)
        {
            try
            {
                var URI = Android.Net.Uri.Parse(string.Format("tel:{0}", phoneNumber));
                var intent = new Intent(Intent.ActionCall, URI);
                Xamarin.Forms.Forms.Context.StartActivity(intent);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
    }
}
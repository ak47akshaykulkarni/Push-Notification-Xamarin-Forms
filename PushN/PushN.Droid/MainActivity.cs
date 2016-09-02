using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using Gcm.Client;

namespace PushN.Droid
{
    [Activity(Label = "PushN", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        public static MainActivity instance;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            instance = this;
           

            RegisterWithGCM();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
        private void RegisterWithGCM()
        {
            // Check to ensure everything's set up right
            GcmClient.CheckDevice(this);
            GcmClient.CheckManifest(this);

            // Register for push notifications
            Log.Info("MainActivity", "Registering...");
            GcmClient.Register(this, Constants.SenderID);
        }

    }
}


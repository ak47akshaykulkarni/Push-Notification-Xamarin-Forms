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

namespace PushN.Droid
{
    class Constants
    {
        public const string SenderID = "Google-Project-Number"; // Google API Project Number
        public const string ListenConnectionString = "Notification-hub-connection-string";
        public const string NotificationHubName = "Notification-Hub-Name";
    }
}
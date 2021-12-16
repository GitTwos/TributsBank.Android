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

namespace AppSorriaBank.Droid
{
    [BroadcastReceiver(Enabled = true, Label = "Local Notifications Broadcast Receiver")]
    public class AlarmHandler : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (intent?.Extras != null)
            {
                string title = intent.GetStringExtra(AndroidLocalNotificationManager.TitleKey);
                string message = intent.GetStringExtra(AndroidLocalNotificationManager.MessageKey);

                AndroidLocalNotificationManager manager = AndroidLocalNotificationManager.Instance ?? new AndroidLocalNotificationManager();
                manager.Show(title, message);
            }
        }
    }
}
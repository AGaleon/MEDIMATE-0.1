using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.Core.App;

namespace MEDIMATE_0._1.Droid
{
    [Service]
    public class MyForegroundService : Service
    {
        public const int SERVICE_RUNNING_NOTIFICATION_ID = 10000;

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            var notification = CreateNotification();
            StartForeground(SERVICE_RUNNING_NOTIFICATION_ID, notification);

            // TODO: Add your service logic here

            return StartCommandResult.Sticky;
        }

        public override void OnDestroy()
        {
            // Cleanup service
            base.OnDestroy();
        }

        private Notification CreateNotification()
        {
            var channelId = "my_foreground_service";
            var channelName = "Foreground Service";

            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            var channel = new NotificationChannel(channelId, channelName, NotificationImportance.Default);
            notificationManager.CreateNotificationChannel(channel);

            var notification = new NotificationCompat.Builder(this, channelId)
                .SetContentTitle("Service Running")
                .SetContentText("This is a foreground service")
                
                .Build();

            return notification;
        }
    }
}

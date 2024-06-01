using Android.Content;
using MEDIMATE_0._1.Droid;

[assembly: Dependency(typeof(ForegroundServiceHelper))]
namespace MEDIMATE_0._1.Droid
{
    public class ForegroundServiceHelper : IForegroundService
    {
        public void StartService()
        {
            var intent = new Intent(Android.App.Application.Context, typeof(MyForegroundService));
            Android.App.Application.Context.StartForegroundService(intent);
        }

        public void StopService()
        {
            var intent = new Intent(Android.App.Application.Context, typeof(MyForegroundService));
            Android.App.Application.Context.StopService(intent);
        }
    }
}

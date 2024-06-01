using Microsoft.Maui.Controls.PlatformConfiguration;

using Microsoft.Maui.Controls;



namespace MEDIMATE_0._1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnStartServiceClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IForegroundService>().StartService();
        }

        void OnStopServiceClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IForegroundService>().StopService();
        }
    }

}

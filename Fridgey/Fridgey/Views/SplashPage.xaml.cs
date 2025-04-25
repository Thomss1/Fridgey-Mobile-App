using System.Threading.Tasks;

namespace Fridgey.Views
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            StartTimer();
        }

        private async void StartTimer()
        {
            await Task.Delay(3000);
            await Navigation.PushAsync(new LoginPage());
            Navigation.RemovePage(this);
        }
    }
}

using Fridgey.Views;
namespace Fridgey
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage());
            MainPage = new AppShell();
        }
    }
}

using Xamarin.Forms;
using XamForms.Excercises.Main;

namespace XamForms.Excercises
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            new AppBootstrapper();
            MainPage = AppBootstrapper.CreateMainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

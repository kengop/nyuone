using nyu1.Services;
using Xamarin.Forms;

namespace nyu1
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public App()
        {
            this.InitializeComponent();

            if (UseMockDataStore)
            {
                DependencyService.Register<MockDataStore>();
            }

            this.GoToMainPage();
        }

        private void GoToMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children = {
                    new NavigationPage(new Views.LogView())
                    {
                        Title = "Log",
                        Icon = Device.RuntimePlatform == Device.iOS ? "tab_feed.png" : null
                    },
                    new NavigationPage(new Views.nyu1Page())
                    {
                        Title = "Front",
                        Icon = Device.RuntimePlatform == Device.iOS ? "tab_feed.png" : null
                    },
                    new NavigationPage(new Views.FirstView())
                    {
                        Title = "Browse",
                        Icon = Device.RuntimePlatform == Device.iOS ? "tab_feed.png" : null
                    },
                    new NavigationPage(new Views.WebView())
                    {
                        Title = "WebView",
                        Icon = Device.RuntimePlatform == Device.iOS ? "tab_feed.png" : null
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using Xamarin.Forms;

namespace nyu1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            this.GoToMainPage();
        }

        private void GoToMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children = {
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

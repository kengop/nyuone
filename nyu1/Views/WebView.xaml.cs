using nyu1.ViewModels;
using Xamarin.Forms;

namespace nyu1.Views
{
    public partial class WebView : ContentPage
    {
        public WebView()
        {
            InitializeComponent();

            this.BindingContext = new WebViewModel();
        }

        private void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            this.LoadingLabel.IsVisible = true;
        }

        private void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        {
            this.LoadingLabel.IsVisible = false;
        }
    }
}

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
    }
}

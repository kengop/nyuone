using System;

namespace nyu1.ViewModels
{
    public class WebViewModel : BaseViewModel
    {
        public WebViewModel()
        {
            this.ViewSource = new Uri("https://www.xamarin.com");
        }

        private Uri m_viewSource;
        public Uri ViewSource
        {
            get { return this.m_viewSource; }
            set { SetProperty(ref this.m_viewSource, value); }

        }
        //public WebViewSource ViewSource { get; set; }
    }
}

using System;
using System.Net.Http;
using nyu1.Helpers;

namespace nyu1.ViewModels
{
	public class TsuikaViewModel : ObservableObject
	{
        #region Properties

        public string Hoge
		{
			get { return this.m_hoge; }
			set { this.m_hoge = value; OnPropertyChanged(); }
		}

		public string m_hoge = "初期";

        #endregion

        public TsuikaViewModel()
		{
		}

		private void foo()
		{

		}
	}
}

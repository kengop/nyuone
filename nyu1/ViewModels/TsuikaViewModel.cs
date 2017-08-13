using System.Windows.Input;
using nyu1.Helpers;

using PCLStorage;

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

        private ICommand m_loadFileCommand;

        public ICommand LoadFileCommand
        {
            get
            {
                return this.m_loadFileCommand;
            }
        }

        private ICommand m_saveFileCommand;

        public ICommand SaveFileCommand
        {
            get
            {
                return this.m_saveFileCommand;
            }
        }

        private string m_localData;

        public string LocalData
        {
            get
            {
                return this.m_localData;
            }
            set
            {
                this.SetProperty(ref this.m_localData, value);
            }
        }

        #endregion

        public TsuikaViewModel()
        {
            this.m_loadFileCommand = new Xamarin.Forms.Command(() => this.LoadFile());
            this.m_saveFileCommand = new Xamarin.Forms.Command(() => this.SaveFile());
            this.LocalData = "さしすせそ";
        }

        private async void SaveFile()
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFile file = await rootFolder.CreateFileAsync(
                "data.txt",
                CreationCollisionOption.ReplaceExisting);
            await file.WriteAllTextAsync(this.LocalData);
        }

        private async void LoadFile()
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFile file = await rootFolder.GetFileAsync("data.txt");
            this.LocalData = await file.ReadAllTextAsync();
        }
    }
}

using GalaSoft.MvvmLight;
using Midias.BTSCs.Repositories;

namespace Midias.BTSCs.App.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text == value)
                    return;

                _text = value;
                RaisePropertyChanged(_text);
            }
        }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            var list = Test.TestMethod();
            Text = list[0].Id + " / " + list[0].Libelle;
        }
    }
}
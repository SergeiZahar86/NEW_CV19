using NEW_CV19.ViewModels.Base;

namespace NEW_CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _title;
            //set
            //{
            //    //if (Equals(_Title, value)) return;
            //    //_Title = value;
            //    //OnPropertyChanged();

            //    Set(ref _Title, value);
            //}
            set => Set(ref _title, value);
        }

        #region Заголовок окна

        private string _title = "Анализ статистики CV19";

        #endregion
    }
}
using NEW_CV19.Infrastructure.Commands;
using NEW_CV19.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace NEW_CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        #region Заголовок окна
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
        private string _title = "Анализ статистики CV19";
        #endregion
        #region Status : string - Статус программы
        /// <summary>Статус программы</summary>
        private string _Status = "Готов!";
        /// <summary>Статус программы</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion
        #region Команды
        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion
        #endregion
        public MainWindowViewModel()
        {
            #region Команды
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion
        }
    }
}
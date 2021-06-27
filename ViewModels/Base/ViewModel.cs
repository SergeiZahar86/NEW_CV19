using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NEW_CV19.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        /// <summary>Деструктор</summary>
        public void Dispose()
        {
            Dispose(true);
        }
        private bool _disposed;

        /// <summary>Деструктор</summary>
        /// <param name="disposing">флаг для запуска</param>
        /// <remarks>Освобождение управляемых ресурсов</remarks>
        /// <returns>void</returns>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || _disposed) return;
            _disposed = true;
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>Задача метода - разрешить кольцевые изменения свойств</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field">значение поля</param>
        /// <param name="value">значение свойства</param>
        /// <param name="propertyName">имя изменяемого свойства</param>
        /// <returns>false - если значение поля и свойства совпадают, 
        /// в противном случае - true и вызов метода <see cref="OnPropertyChanged"/></returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

    }
}
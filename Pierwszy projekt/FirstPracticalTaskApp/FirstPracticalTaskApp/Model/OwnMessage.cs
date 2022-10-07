using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FirstPracticalTaskApp.Model
{
    public class OwnMessage: INotifyPropertyChanged
    {
        public int NumberOfMessage { get; set; }
        private string _message;
        public string Message 
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }


        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

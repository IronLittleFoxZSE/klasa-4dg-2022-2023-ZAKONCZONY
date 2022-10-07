using FirstPracticalTaskApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstPracticalTaskApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingPage : ContentPage, INotifyPropertyChanged
    {
        public string Message { get; set; }

        public OwnMessage OwnMessage { get; set; }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public BindingPage()
        {
            InitializeComponent();
            Message = "Komunikat";
            OnPropertyChanged(nameof(Message));

            OwnMessage = new OwnMessage()
            {
                NumberOfMessage = 1,
                Message = "Mój komunikat"
            };
            OnPropertyChanged(nameof(OwnMessage));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Message = "Inny komunikat";
            OnPropertyChanged(nameof(Message));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            OwnMessage = new OwnMessage()
            {
                NumberOfMessage = 2,
                Message = "Jeszcze inny komunikat"
            };
            OnPropertyChanged(nameof(OwnMessage));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            OwnMessage.NumberOfMessage = 99;
            OwnMessage.Message = "Całkowicie inny komunikat";
            //OnPropertyChanged(nameof(OwnMessage));
        }
    }
}
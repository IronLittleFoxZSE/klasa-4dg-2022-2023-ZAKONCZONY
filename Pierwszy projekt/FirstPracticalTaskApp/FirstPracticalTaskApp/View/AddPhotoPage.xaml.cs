using FirstPracticalTaskApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstPracticalTaskApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPhotoPage : ContentPage
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public PhotoInfoViewModel ViewModel { get; set; }

        public AddPhotoPage(PhotoInfoViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Url = "https://img.freepik.com/darmowe-wektory/zmeczony-mlody-pies_1308-25268.jpg";
            ViewModel.AddPhoto(Name, Url);
            Navigation.PopAsync();
        }
    }
}
using FirstPracticalTaskApp.View;
using FirstPracticalTaskApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstPracticalTaskApp
{
    public partial class MainPage : ContentPage
    {
        public PhotoInfoViewModel ViewModel { get; set; }

        public MainPage()
        {
            ViewModel = new PhotoInfoViewModel();
            InitializeComponent();
            BindingContext = ViewModel;
        }

        private void buttonShowImageCarousel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselImagePage(ViewModel));
        }

        private void buttonShowImageList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImageListPage(ViewModel));
        }
    }
}

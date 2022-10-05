using FirstPracticalTaskApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstPracticalTaskApp.ViewModel
{
    public class PhotoInfoViewModel
    {
        public string Title { get; set; }

        public List<PhotoInfo> ListOfPhoto { get; set; }

        public PhotoInfoViewModel()
        {
            Title = "Lista zdjęć";

            ListOfPhoto = new List<PhotoInfo>();

            ListOfPhoto.Add(new PhotoInfo()
            {
                Name = "Pies",
                PhotoUrl = "https://img.freepik.com/darmowe-wektory/zmeczony-mlody-pies_1308-25268.jpg"
            });

            ListOfPhoto.Add(new PhotoInfo()
            {
                Name = "Piesek",
                PhotoUrl = "https://img.freepik.com/darmowe-wektory/ladny-pies-ugryzienie-kosci-kreskowka-wektor-ikona-ilustracja-koncepcja-ikona-zywnosci-zwierzat-na-bialym-tle-premium-wektor-plaski-styl-kreskowki_138676-4161.jpg"
            });

            ListOfPhoto.Add(new PhotoInfo()
            {
                Name = "Kotki",
                PhotoUrl = "https://img.freepik.com/darmowe-wektory/ladny-kot-i-pies-corgi-kreskowka-wektor-ikona-ilustracja-koncepcja-ikona-przyjaciela-zwierzat-na-bialym-tle-premium-wektor-plaski-styl-kreskowki_138676-3558.jpg"
            });
        }

    }
}

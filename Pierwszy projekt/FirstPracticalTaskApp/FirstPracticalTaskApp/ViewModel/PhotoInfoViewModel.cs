using FirstPracticalTaskApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace FirstPracticalTaskApp.ViewModel
{
    public class PhotoInfoViewModel: INotifyPropertyChanged
    {
        public string Title { get; set; }

        public ObservableCollection<PhotoInfo> ListOfPhoto { get; set; }
        /*private List<PhotoInfo> _listOfPhoto;
        public List<PhotoInfo> ListOfPhoto
        { 
            get
            {
                return _listOfPhoto;
            }
            set
            {
                _listOfPhoto = value;
                OnPropertyChanged(nameof(ListOfPhoto));
            }
        }*/

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public PhotoInfoViewModel()
        {
            Title = "Lista zdjęć";

            ListOfPhoto = new ObservableCollection<PhotoInfo>();

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

        public void AddPhoto(string name, string url)
        {
            ListOfPhoto.Add(new PhotoInfo()
            {
                Name = name,
                PhotoUrl = url
            });
        }

    }
}

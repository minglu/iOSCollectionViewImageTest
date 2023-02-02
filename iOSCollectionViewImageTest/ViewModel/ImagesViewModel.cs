using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace iOSCollectionViewImageTest.ViewModel
{
    public partial class ImagesViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<string> photoUrls;

        public ImagesViewModel()
        {
            List<string> urls = new List<string>()
            {
                "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Google_Images_2015_logo.svg/220px-Google_Images_2015_logo.svg.png",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Google_Images_2015_logo.svg/220px-Google_Images_2015_logo.svg.png",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Google_Images_2015_logo.svg/220px-Google_Images_2015_logo.svg.png",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Google_Images_2015_logo.svg/220px-Google_Images_2015_logo.svg.png",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Google_Images_2015_logo.svg/220px-Google_Images_2015_logo.svg.png",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Google_Images_2015_logo.svg/220px-Google_Images_2015_logo.svg.png",
            };

            PhotoUrls = new ObservableCollection<string>(urls);
        }
    }
}


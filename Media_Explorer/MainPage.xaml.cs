using System;
using System.Collections.ObjectModel;
using Media_Explorer.Models;

namespace Media_Explorer
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Media> MediaCollection { get; set; }

        public MainPage()
        {
            InitializeComponent();

            MediaCollection = new ObservableCollection<Media>
            {
                new ImageMedia("Sample Image", 1024, DateTime.Now, 800, 600),
                new Video("Sample Video", 2048, DateTime.Now, TimeSpan.FromMinutes(2)),
                new Music("Sample Music", 512, DateTime.Now, "Artist", "Album", "Genre")
            };

            MediaCollectionView.ItemsSource = MediaCollection;
        }
    }
}

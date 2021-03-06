using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DemoLibrary;

namespace ApiCallApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int maxNumber = 0;
        private int currentNumber = 0;
        public string Info { get; set; }

        public MainWindow()
        {
            InitializeComponent(); //>> will run Window_Loaded event per Main Window XAML

            //Static method for creating asnyc API client for application to use.
            ApiHelper.InitializeClient();
            comicInfo.DataContext = Info;

        }


        //upon main-window starting, LoadImage() is ran to fetch latest image from xckd comic website
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadImage();          

        }

        //uses fetches comic from website. If argument is not give it is defaulted to 0 which will pull the latest comic from website. Also keeps track of what comic application is on for Prev and Next buttons.
        private async Task LoadImage(int imageNumber = 0)
        {
            var comic = await ComicProcessor.LoadComic(imageNumber);
            
            if(imageNumber == 0)
            {
                maxNumber = comic.Num;
            }

            currentNumber = comic.Num;

            comicInfo.Content = $"{comic.Date}: {comic.Title}";

            var uriSource = new Uri(comic.Img, UriKind.Absolute);
            comicImage.Source = new BitmapImage(uriSource);

           
        }
      

        private async void previousImageButton_Click(object sender, RoutedEventArgs e)
        {
            await LoadImage(currentNumber - 1);
            nextImageButton.IsEnabled = true;
            
        }

        private void sunInformationButton_Click(object sender, RoutedEventArgs e)
        {
            SunInfo sunInfoWindow = new SunInfo();
            sunInfoWindow.Show();
        }

        private async void nextImageButton_Click(object sender, RoutedEventArgs e)
        {                        
            await LoadImage(currentNumber + 1);
            if (currentNumber >= maxNumber)
                nextImageButton.IsEnabled = false;
        }
    }
}

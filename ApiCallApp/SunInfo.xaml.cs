using DemoLibrary;
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
using System.Windows.Shapes;

namespace ApiCallApp
{
    /// <summary>
    /// Interaction logic for SunInfo.xaml
    /// </summary>
    public partial class SunInfo : Window
    {
        private string locationUrl = "https://api.sunrise-sunset.org/json?lat=48.0517637&lng=-122.1770818=today";

        public SunInfo()
        {
            InitializeComponent();
        }

        public async Task LoadSunSetInfo(string locationUrl)
        {
            var sunSetnRiseInfo = await SunInfoProcessor.GetSunsetTime(locationUrl);
            FirstLightText.Text = $"First light at {sunSetnRiseInfo.Results.Civil_Twilight_Begin.ToLocalTime().ToShortTimeString()}";
            SunriseText.Text = $"Sunrise time: {sunSetnRiseInfo.Results.SunRise.ToLocalTime().ToShortTimeString()}";
            SunsetText.Text = $"Sunset time: {sunSetnRiseInfo.Results.SunSet.ToLocalTime().ToShortTimeString()}";
            LastLightText.Text = $"Last light at {sunSetnRiseInfo.Results.Nautical_Twilight_End.ToLocalTime().ToShortTimeString()}";

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                await LoadSunSetInfo(locationUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}

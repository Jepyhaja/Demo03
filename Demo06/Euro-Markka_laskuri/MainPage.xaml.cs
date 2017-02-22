using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Euro_Markka_laskuri
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        //must set to flip flops properly
        double value;
        string feed;

        private void Euroiksi_button_Click(object sender, RoutedEventArgs e)
        {
            //Easymode
            value = double.Parse(FeedBox.Text);
            value = value / 5.94573;
            PrintBox.Text = value.ToString("0.00");
        }

        private void Markoiksi_button_Click(object sender, RoutedEventArgs e)
        {
            //Trickcoding flippin flops
            feed = FeedBox.Text.ToString();
            value = double.Parse(feed);
            value = value * 5.94573;
            PrintBox.Text = value.ToString("0.00");

        }
    }
}

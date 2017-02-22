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

namespace Ikkuna_pinta_ala
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
        double Kwidth;
        double Garea;
        double Warea;
        double Kcirc;


        private void Laske_Click(object sender, RoutedEventArgs e)
        {
       
            Width = double.Parse(Leveys.Text);
            Height = double.Parse(Korkeus.Text);
            Kwidth = double.Parse(Karmipuu.Text);


            Garea = (Width - 2 * Kwidth) * (Height - 2 * Kwidth) / 100;
            LasinAla_out.Text = Garea.ToString() + " cm^2";

            Warea = Width * Height /100;
            IkkunanAla_out.Text = Warea.ToString() + "cm^2";

            Kcirc = (Width + Width + Height + Height) / 10;
            Karminpiiri_out.Text = Kcirc.ToString() + "cm";

        }
    }
}

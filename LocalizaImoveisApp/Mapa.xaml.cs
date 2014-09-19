using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace LocalizaImoveisApp
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
            String url = "http://maps.googleapis.com/maps/api/staticmap?center=Belo+Horizonte,Centro,MG&zoom=15&size=200x305&markers=color:red%7Clabel:I%7C-19.920088,-43.938645&markers=color:red%7Clabel:I%7C-19.918978,-43.939697&markers=color:red%7Clabel:I%7C-19.918676,-43.939310";
            imageMap.Source = new BitmapImage(new Uri(url, UriKind.Absolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Maps.Controls;

namespace LocalizaImoveisApp
{
    public partial class Mapa : PhoneApplicationPage
    {
        public Mapa()
        {
            InitializeComponent();
            Map mapa1 = new Map();
            ContentPanel.Children.Add(mapa1);
        }

        public void getMap(){

            Map mapa1 = new Map();
            ContentPanel.Children.Add(mapa1);
        }
    }
}
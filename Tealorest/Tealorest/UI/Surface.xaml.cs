using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Tealorest.UI
{
    public partial class Surface : UserControl
    {
        public string ImagePath;

        public Surface() => InitializeComponent();

        public Surface(string name, Size size)
        {
            ImagePath = name;

            InitializeComponent();

            xImage.Source = new BitmapImage(new Uri(name));
            xImage.Width = size.Width;
            xImage.Height = size.Height;
        }
    }
}

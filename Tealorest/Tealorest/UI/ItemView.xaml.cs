using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Tealorest.UI
{
    public partial class ItemView : UserControl
    {
        public ItemView() => InitializeComponent();

        public ItemView(string name)
        {
            InitializeComponent();
            SetSource(name);
        }

        private void SetSource(string name)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Data", "images", $"{name}.png");
            xImage.Source = new BitmapImage(new Uri(path));
        }
    }
}

using System.Windows;
using System.Windows.Media;
using Tealorest.Data;
using Tealorest.UI;

namespace Tealorest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Palette palette = new Palette() { Color1 = Color.FromRgb(19, 19, 19) };

            Content = new PlayView(palette);
        }
    }
}

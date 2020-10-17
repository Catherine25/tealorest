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

            Palette palette = new Palette()
            {
                BackgroundColor = Color.FromRgb(0, 43, 54),
                ForegroundColor = Color.FromRgb(253, 246, 227)
            };

            Content = new PlayView(palette);
        }
    }
}

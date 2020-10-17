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
                LightestMain = Color.FromRgb(253,246,227),
                LightestAdditional = Color.FromRgb(238,232,213),

                LighterMiddleMain = Color.FromRgb(147,161,161),
                LighterMiddleAdditional = Color.FromRgb(131,148,150),

                DarkerMiddleMain = Color.FromRgb(88,110,117),
                DarkerMiddleAdditional = Color.FromRgb(101,123,131),

                DarkestMain = Color.FromRgb(0,43,54),
                DarkestAdditional = Color.FromRgb(7,54,66)
            };

            Content = new PlayView(palette);
        }
    }
}

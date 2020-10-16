using System.Windows.Controls;
using System.Windows.Media;
using Tealorest.Data;

namespace Tealorest.UI
{
    public partial class PlayView : UserControl
    {
        public PlayView() => InitializeComponent();

        public PlayView(Palette palette)
        {
            InitializeComponent();

            xTopBorder.Fill = new SolidColorBrush(palette.Color1);
            xBottomBorder.Fill = new SolidColorBrush(palette.Color1);
        }
    }
}

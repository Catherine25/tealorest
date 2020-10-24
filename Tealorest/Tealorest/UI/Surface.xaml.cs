using System.Windows;
using System.Windows.Controls;

namespace Tealorest.UI
{
    public partial class Surface : UserControl
    {
        public Surface() => InitializeComponent();

        public Surface(Size size)
        {
            InitializeComponent();

            xImage.Width = size.Width;
            xImage.Height = size.Height;
        }
    }
}

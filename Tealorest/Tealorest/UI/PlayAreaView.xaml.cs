using System.Windows;
using System.Windows.Controls;
using Tealorest.Data;

namespace Tealorest.UI
{
    public partial class PlayAreaView : UserControl
    {
        public PlayAreaView()
        {
            InitializeComponent();
            Loaded += PlayAreaView_Loaded;
        }

        private void PlayAreaView_Loaded(object sender, RoutedEventArgs e) => DrawSurface();

        public void Add(Character.Character character) =>
            xMain.Children.Add(character);

        private void DrawSurface()
        {
            Size surfaceSize = Settings.GetSize("surface");
            Size gridSize = xMain.GetSize();

            int count = (int)(gridSize.Width / surfaceSize.Width) + 1;

            for (int i = 0; i < count; i++)
            {
                Surface surface = new Surface(surfaceSize)
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Bottom
                };

                surface.ModifyMarginLeft(surfaceSize.Width * i);

                xMain.Children.Add(surface);
            }
        }
    }
}

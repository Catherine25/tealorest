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

        private void PlayAreaView_Loaded(object sender, RoutedEventArgs e)
        {
            GenerateItems(1);
            DrawSurface();
        }

        public void Add(Character.Character character) =>
            xMiddle.Children.Add(character);

        private void DrawSurface()
        {
            Size surfaceSize = Settings.GetSize("surface");
            int count = xFront.GetGridItemsCount(surfaceSize);

            for (int i = 0; i < count; i++)
            {
                Surface surface = new Surface(surfaceSize);

                surface.ModifyMarginLeft(surfaceSize.Width * i);

                xFront.Children.Add(surface);
            }
        }

        private void GenerateItems(int count)
        {
            Size treeSize = Settings.GetSize("tree");
            int countt = xBack.GetGridItemsCount(treeSize);

            for (int i = 0; i < countt; i++)
            {
                ItemView item = new ItemView("tree");

                item.ModifyMarginLeft(treeSize.Width * i);

                xBack.Children.Add(item);
            }
        }
    }
}

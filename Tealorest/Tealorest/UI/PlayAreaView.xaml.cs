using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
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
            //getting images
            string initialPath = Path.Combine(Environment.CurrentDirectory, "Data", "images", "grass");
            List<string> fileNames = GetItemNames(initialPath);

            //getting sizes
            Size surfaceSize = Data.Settings.GetSize("surface");
            int count = xFront.GetGridItemsCount(surfaceSize);

            //randomize surface images
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Surface surface = new Surface(Path.Combine(initialPath, fileNames[random.Next(fileNames.Count)]), surfaceSize);

                surface.ModifyMarginLeft(surfaceSize.Width * i);

                xFront.Children.Add(surface);
            }
        }

        private void GenerateItems(int count)
        {
            Size treeSize = Data.Settings.GetSize("tree");
            int countt = xBack.GetGridItemsCount(treeSize);

            for (int i = 0; i < countt; i++)
            {
                ItemView item = new ItemView("tree");

                item.ModifyMarginLeft(treeSize.Width * i);

                xBack.Children.Add(item);
            }
        }

        private List<string> GetItemNames(string path)
        {
            List<string> files = new List<string>();

            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] Files = d.GetFiles("*.png");

            foreach(FileInfo file in Files)
                files.Add(file.Name);

            return files;
        }
    }
}

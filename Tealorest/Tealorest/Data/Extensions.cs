using System.Windows;
using System.Windows.Controls;

namespace Tealorest.Data
{
    public static class Extensions
    {
        public static Size GetSize(this FrameworkElement element) =>
            new Size(element.ActualWidth, element.ActualHeight);

        public static void SetSize(this FrameworkElement element, Size size)
        {
            element.Width = size.Width;
            element.Height = size.Height;
        }

        public static void ModifyMarginLeft(this FrameworkElement element, double left)
        {
            Thickness margin = element.Margin;
            margin.Left += left;
            element.Margin = margin;
        }

        public static void ModifyMarginRight(this FrameworkElement element, double right)
        {
            Thickness margin = element.Margin;
            margin.Right += right;
            element.Margin = margin;
        }

        public static void ModifyMarginTop(this FrameworkElement element, double top)
        {
            Thickness margin = element.Margin;
            margin.Top += top;
            element.Margin = margin;
        }

        public static void ModifyMarginBottom(this FrameworkElement element, double bottom)
        {
            Thickness margin = element.Margin;
            margin.Bottom += bottom;
            element.Margin = margin;
        }

        public static int GetGridItemsCount(this Grid grid, Size itemSize)
        {
            Size gridSize = grid.GetSize();

            int count = (int)(gridSize.Width / itemSize.Width) + 1;

            return count;
        }
    }
}

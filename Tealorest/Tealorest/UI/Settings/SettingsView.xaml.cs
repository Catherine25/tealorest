using System.Windows.Controls;
using System.Windows.Media;

namespace Tealorest.UI.Settings
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();

            Foreground = new SolidColorBrush(Data.Settings.GetColor("lightest-main"));

            xGrid.Children.Add(new SettingsEntry("palette-lightest-main", Data.Settings.GetColor("lightest-main").ToString()));
        }
    }
}

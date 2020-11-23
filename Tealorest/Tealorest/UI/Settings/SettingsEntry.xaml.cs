using System.Windows.Controls;
using System.Windows.Media;

namespace Tealorest.UI.Settings
{
    public partial class SettingsEntry : UserControl
    {
        public SettingsEntry() => InitializeComponent();

        public SettingsEntry(string key, string value)
        {
            InitializeComponent();

            xKey.Text = key;
            xValue.Text = value;

            Background = new SolidColorBrush(Data.Settings.GetColor("darkest-main"));
        }
    }
}

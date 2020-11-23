using System.Windows;
using System.Windows.Input;
using Tealorest.Data;
using Tealorest.UI;
using Tealorest.UI.Settings;

namespace Tealorest
{
    public partial class MainWindow : Window
    {
        private readonly KeyMapping KeyMapping;
        private PlayView PlayView;
        private SettingsView SettingsView;

        public MainWindow()
        {
            InitializeComponent();

            KeyMapping = new KeyMapping();
            KeyMapping.Mapping.Add(Settings.GetKeyMapping(Direction.Left), Direction.Left);
            KeyMapping.Mapping.Add(Settings.GetKeyMapping(Direction.Right), Direction.Right);

            Palette palette = new Palette()
            {
                LightestMain = Settings.GetColor("lightest-main"),
                LightestAdditional = Settings.GetColor("lightest-additional"),

                LighterMiddleMain = Settings.GetColor("lighter-middle-main"),
                LighterMiddleAdditional = Settings.GetColor("lighter-middle-additional"),

                DarkerMiddleMain = Settings.GetColor("darker-middle-main"),
                DarkerMiddleAdditional = Settings.GetColor("darker-middle-additional"),

                DarkestMain = Settings.GetColor("darkest-main"),
                DarkestAdditional = Settings.GetColor("darkest-additional")
            };

            PlayView = new PlayView(palette);
            PlayView.SettingsButtonClicked += PlayView_SettingsButtonClicked;
            Content = PlayView;

            KeyDown += MainWindow_KeyDown;
        }

        private void PlayView_SettingsButtonClicked()
        {
            SettingsView = new SettingsView();
            Content = SettingsView;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e) =>
            (Content as PlayView).MoveCharacter(KeyMapping.Map(e.Key));
    }
}

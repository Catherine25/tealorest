using System.Windows;
using System.Windows.Input;
using Tealorest.Data;
using Tealorest.UI;

namespace Tealorest
{
    public partial class MainWindow : Window
    {
        private readonly KeyMapping KeyMapping;

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

            Content = new PlayView(palette);

            KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e) =>
            (Content as PlayView).MoveCharacter(KeyMapping.Map(e.Key));
    }
}

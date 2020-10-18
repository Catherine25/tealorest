using System.Windows.Controls;
using System.Windows.Media;
using Tealorest.Data;

namespace Tealorest.UI
{
    public partial class PlayView : UserControl
    {
        public PlayView() => InitializeComponent();

        private Character.Character _character;

        public PlayView(Palette palette)
        {
            InitializeComponent();

            Brush brush = new SolidColorBrush(palette.DarkestMain);
            Brush brush2 = new SolidColorBrush(palette.LightestMain);

            xTopBorder.Fill = brush;
            xBottomBorder.Fill = brush;

            xPlayButton.Background = brush;
            xSettingsButton.Background = brush;
            xExitButton.Background = brush;

            xPlayButton.Foreground = brush2;
            xSettingsButton.Foreground = brush2;
            xExitButton.Foreground = brush2;

            _character = new Character.Character();
            xPlayArea.Children.Add(_character);
        }

        public void MoveCharacter(Direction? direction)
        {
            if (direction == null)
                return;

            _character.Move(direction.Value, 8);
        }
    }
}

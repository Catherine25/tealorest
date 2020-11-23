using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Tealorest.Data;

namespace Tealorest.UI
{
    public partial class PlayView : UserControl
    {
        private Character.Character _character;

        public PlayView() => InitializeComponent();

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

            xPlayArea.Background = new SolidColorBrush(palette.DarkestAdditional);
            _character = new Character.Character();
            xPlayArea.Add(_character);

            xPlayButton.Click += (object o, RoutedEventArgs e) => PlayButtonClicked();
            xSettingsButton.Click += (object o, RoutedEventArgs e) => SettingsButtonClicked();
            xExitButton.Click += (object o, RoutedEventArgs e) => App.Current.Shutdown();
        }

        public event Action PlayButtonClicked;
        public event Action SettingsButtonClicked;

        public void MoveCharacter(Direction? direction)
        {
            if (direction == null)
                return;

            _character.Move(direction.Value);
        }
    }
}

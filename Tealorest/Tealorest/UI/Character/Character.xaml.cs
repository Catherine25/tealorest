using System.Windows.Controls;
using Tealorest.Data;
using static System.Windows.Visibility;

namespace Tealorest.UI.Character
{
    public partial class Character : UserControl
    {
        public Character()
        {
            InitializeComponent();

            xCharacterRight.Visibility = Visible;

            xAsset.Height = 128;
            xAsset.Width = 128;
        }

        private void Turn(Direction direction)
        {
            if (direction == Direction.Left)
            {
                xCharacterLeft.Visibility = Visible;
                xCharacterRight.Visibility = Hidden;
            }
            else
            {
                xCharacterRight.Visibility = Visible;
                xCharacterLeft.Visibility = Hidden;
            }
        }

        public void Move(Direction direction, int pixels)
        {
            Turn(direction);

            var margin = Margin;

            if (direction == Direction.Left)
                margin.Left -= pixels;
            else
                margin.Left += pixels;

            Margin = margin;
        }
    }
}

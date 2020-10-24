using System.Configuration;
using System.Windows.Controls;
using Tealorest.Data;
using static System.Windows.Visibility;

namespace Tealorest.UI.Character
{
    public partial class Character : UserControl
    {
        private readonly int StepSize;

        public Character()
        {
            InitializeComponent();

            StepSize = int.Parse(ConfigurationManager.AppSettings["character-step"]);

            xCharacterRight.Visibility = Visible;

            xAsset.SetSize(Settings.GetSize("character"));
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

        public void Move(Direction direction)
        {
            Turn(direction);

            var margin = Margin;

            if (direction == Direction.Left)
                margin.Left -= StepSize;
            else
                margin.Left += StepSize;

            Margin = margin;
        }
    }
}

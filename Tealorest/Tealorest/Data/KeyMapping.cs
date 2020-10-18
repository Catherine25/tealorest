using System.Collections.Generic;
using System.Windows.Input;

namespace Tealorest.Data
{
    public enum Direction
    {
        Right = 0,
        Left = 1
    }

    public class KeyMapping
    {
        private Dictionary<Key, Direction> Mapping = new Dictionary<Key, Direction>
        {
            { Key.A, Direction.Left },
            { Key.D, Direction.Right },
            { Key.Left, Direction.Left },
            { Key.Right, Direction.Right  }
        };

        public Direction? Map(Key key) =>
            Mapping.ContainsKey(key) ? (Direction?)Mapping[key] : null;
    }
}

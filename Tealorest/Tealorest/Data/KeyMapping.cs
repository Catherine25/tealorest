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
        public Dictionary<Key, Direction> Mapping = new Dictionary<Key, Direction>();

        public Direction? Map(Key key) =>
            Mapping.ContainsKey(key) ? (Direction?)Mapping[key] : null;
    }
}

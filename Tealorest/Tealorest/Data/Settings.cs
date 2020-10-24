using System;
using System.Configuration;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Tealorest.Data
{
    public static class Settings
    {
        private const string _palettePrefix = "palette-";
        private const string _keyMappingPrefix = "key-mapping-";
        private const string _widthPostfix = "-width";
        private const string _heightPostfix = "-height";

        private static string GetValue(string key) => ConfigurationManager.AppSettings[key];
        private static int GetIntValue(string key) => int.Parse(GetValue(key));

        public static Color GetColor(string key) =>
            (Color)ColorConverter.ConvertFromString(GetValue(_palettePrefix + key));

        public static Key GetKeyMapping(Direction direction) =>
            (Key)Enum.Parse(typeof(Key), GetValue(_keyMappingPrefix + direction.ToString().ToLower()));

        public static Size GetSize(string objectName) =>
            new Size(GetWidth(objectName), GetHeight(objectName));

        private static int GetWidth(string objectName) =>
            GetIntValue(objectName + _widthPostfix);
        
        private static int GetHeight(string objectName) =>
            GetIntValue(objectName + _heightPostfix);
    }
}

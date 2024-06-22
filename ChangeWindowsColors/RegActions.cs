using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeWindowsColors
{
    class RegActions
    {
        public static void ParseRegistryKeys(ref Dictionary<string, string> paramValue)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true);
            List<string> vals = key.GetValueNames().ToList();
            for (int i = 0; i < vals.Count; i++)
            {
                paramValue.Add(vals[i], key.GetValue(vals[i]).ToString());
            }
            key.Close();
        }
        public static void SetRegistryValues(string name, object value)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true);
            key.SetValue(name, value);
            key.Close();
        }
    }
}

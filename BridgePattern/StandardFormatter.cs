using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class StandardFormatter : IFormatter
    {
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", ReverseString(key), ReverseString(value));
        }

        
    }
}

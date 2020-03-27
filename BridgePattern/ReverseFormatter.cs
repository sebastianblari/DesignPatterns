using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}, {1}", key, value);
        }
    }
}

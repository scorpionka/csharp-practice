using System;
using System.Collections.Generic;
using System.Text;

namespace lect14.task1
{
    static class StringExtension
    {
        public static void FormatString(this ClassString classString, string str)
        {
            str = str.Substring(0, 5);
            str = String.Concat(str, "...");
            classString.text = str;
        }
    }
}

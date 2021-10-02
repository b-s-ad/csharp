using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE4 = @"([\w]+)@([\w]+)\.([\w][\w][\w])$";

        public bool validateIVE4(string IVE4)
        {
            return Regex.IsMatch(IVE4, Regex_IVE4);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE8 = @"(^[\w]+@[a-zA-Z0-9]+)\.([\w][\w][\w])$";

        public bool validateIVE8(string IVE8)
        {
            return Regex.IsMatch(IVE8, Regex_IVE8);
        }
    }

}

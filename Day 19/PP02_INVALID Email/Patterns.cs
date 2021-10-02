using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE10 = @"(^[\w]+@[\w]+)\.([\w][\w][\w])$";

        public bool validateIVE10(string IVE10)
        {
            return Regex.IsMatch(IVE10, Regex_IVE10);
        }
    }

}

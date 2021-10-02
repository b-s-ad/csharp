using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE12 = @"(^[\w]+@[\w]+)\.([\w][\w][\w])\.[a-zA-Za-zA-Z]{2,2}$";

        public bool validateIVE12(string IVE12)
        {
            return Regex.IsMatch(IVE12, Regex_IVE12);
        }
    }

}

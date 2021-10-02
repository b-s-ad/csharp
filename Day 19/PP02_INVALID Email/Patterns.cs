using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE13 = @"(^[\w]+@[\w]+)\.([\w][\w][\w])\.[a-zA-Za-zA-Z]{2,2}$";

        public bool validateIVE13(string IVE13)
        {
            return Regex.IsMatch(IVE13, Regex_IVE13);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE8 = "^[a-zA-z]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}[.][a-zA-z]{2,3}$";

        public bool validateVE8(string VE8)
        {
            return Regex.IsMatch(VE8, Regex_VE8);
        }
    }

}

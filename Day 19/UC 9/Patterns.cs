using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE9 = "^([a-zA-z+0-9])+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";

        public bool validateVE9(string VE9)
        {
            return Regex.IsMatch(VE9, Regex_VE9);
        }
    }

}

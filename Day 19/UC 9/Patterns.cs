using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE3 = "^[a-zA-z.0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$";

        public bool validateVE3(string VE3)
        {
            return Regex.IsMatch(VE3, Regex_VE3);
        }
    }

}

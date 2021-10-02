using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE1 = "^[a-zA-Z]+[@]$";

        public bool validateIVE1(string IVE1)
        {
            return Regex.IsMatch(IVE1, Regex_IVE1);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE7 = "^[a-zA-z]+[@]+[0-9]+[.][a-zA-Z]{2,3}$";
       
        public bool validateVE7(string VE7)
        {
            return Regex.IsMatch(VE7, Regex_VE7);
        }
    }

}

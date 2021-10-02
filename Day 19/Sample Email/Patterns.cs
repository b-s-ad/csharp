using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE2 = "^[a-zA-z-0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$"; 
       
        public bool validateVE2(string VE2)
        {
            return Regex.IsMatch(VE2, Regex_VE2);
        }
    }

}

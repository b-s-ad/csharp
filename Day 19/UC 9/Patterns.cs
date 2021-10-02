using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE4 = "^[a-zA-z0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$"; 
       
        public bool validateVE4(string VE4)
        {
            return Regex.IsMatch(VE4, Regex_VE4);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE6 = "^[a-zA-z.0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}[.][a-zA-z]{2,2}$"; 
       
        public bool validateVE6(string VE6)
        {
            return Regex.IsMatch(VE6, Regex_VE6);
        }
    }

}

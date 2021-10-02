using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE5 = "^[a-zA-z-0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$"; 
       
        public bool validateVE5(string VE5)
        {
            return Regex.IsMatch(VE5, Regex_VE5);
        }
    }

}

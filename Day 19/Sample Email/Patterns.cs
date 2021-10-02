using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_VE1 = "^[a-zA-z]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}$"; 
       
        public bool validateVE1(string VE1)
        {
            return Regex.IsMatch(VE1, Regex_VE1);
        }
    }

}

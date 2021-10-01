using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_Rule2 = "(?=.*[a-z])(?=.*[A-Z]).{8,}$"; 
       
        public bool validateRule2(string Rule2)
        {
            return Regex.IsMatch(Rule2, Regex_Rule2);
        }
    }

}

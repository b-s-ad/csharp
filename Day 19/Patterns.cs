using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_Rule3 = "(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z]).{8,}$"; 
       
        public bool validateRule3(string Rule3)
        {
            return Regex.IsMatch(Rule3, Regex_Rule3);
        }
    }

}

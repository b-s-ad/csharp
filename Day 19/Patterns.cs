using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_Rule4 = "(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-])(?=.*[A-Z]).{8,}$"; 
       
        public bool validateRule4(string Rule4)
        {
            return Regex.IsMatch(Rule4, Regex_Rule4);
        }
    }

}

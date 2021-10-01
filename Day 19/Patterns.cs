using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_Minpass = "^[A-Za-z*]{8,}$"; 
       
        public bool validateMinpass(string Minpass)
        {
            return Regex.IsMatch(Minpass, Regex_Minpass);
        }
    }

}

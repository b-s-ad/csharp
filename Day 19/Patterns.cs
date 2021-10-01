using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_MobileFormat = "^[9][1][ ][1-9][0-9]{9}$"; 
       
        public bool validateMobileFormat(string MobileFormat)
        {
            return Regex.IsMatch(MobileFormat, Regex_MobileFormat);
        }
    }

}

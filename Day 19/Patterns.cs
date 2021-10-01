using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_Pincode = "^([A-Z][a-zA-Z0-9]*)$";
       
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, Regex_Pincode);
        }
    }

}

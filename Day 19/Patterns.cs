using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_Lastname = "^[a-z]*[ ]([A-Z][a-z0-9]*)$";
       
        public bool validateLastname(string Lastname)
        {
            return Regex.IsMatch(Lastname, Regex_Lastname);
        }
    }

}

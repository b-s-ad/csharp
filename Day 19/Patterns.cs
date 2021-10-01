using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_Validemail = "^[a-z][-a-z0-9._]+@([-a-z0-9{2,2}]+[.])+[a-z]{2,2}$"; 
       
        public bool validateValidemail(string Validemail)
        {
            return Regex.IsMatch(Validemail, Regex_Validemail);
        }
    }

}

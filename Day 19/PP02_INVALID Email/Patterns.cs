using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE6 = @"(\b^[\w]+@[\w]+)\.([\w][\w][\w]\b)$";

        public bool validateIVE6(string IVE6)
        {
            return Regex.IsMatch(IVE6, Regex_IVE6);
        }
    }

}

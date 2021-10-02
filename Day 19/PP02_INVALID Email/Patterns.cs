using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE3 = @"([\w]+)@([\w]+)\.([\w][\w])$";

        public bool validateIVE3(string IVE3)
        {
            return Regex.IsMatch(IVE3, Regex_IVE3);
        }
    }

}

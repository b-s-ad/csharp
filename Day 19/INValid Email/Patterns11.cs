using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns11
    {
        public static string Regex_IVE11 = @"(^[\w]+@[\w]+)\.([\w][\w][\w])$";

        public bool validateIVE11(string IVE11)
        {
            return Regex.IsMatch(IVE11, Regex_IVE11);
        }
    }

}
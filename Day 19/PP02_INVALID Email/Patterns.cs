using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns
    {
        public static string Regex_IVE9 = @"(^[\w]+.{1}[\d]+@[\w]+)\.([\w][\w][\w])$";

        public bool validateIVE9(string IVE9)
        {
            return Regex.IsMatch(IVE9, Regex_IVE9);
        }
    }

}

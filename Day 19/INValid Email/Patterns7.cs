using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns7
    {
        public static string Regex_IVE7 = @"(^[\w-_]+@[\w]+)\.([\w][\w][\w])$";

        public bool validateIVE7(string IVE7)
        {
            return Regex.IsMatch(IVE7, Regex_IVE7);
        }
    }

}
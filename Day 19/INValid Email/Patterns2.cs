using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns2
    {
        public static string Regex_IVE2 = @"([\w]+)@([\w]+)\.([\w][\w][\w])\.([\w][\w])$";

        public bool validateIVE2(string IVE2)
        {
            return Regex.IsMatch(IVE2, Regex_IVE2);
        }
    }

}
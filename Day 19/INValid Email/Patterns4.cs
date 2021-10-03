using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns4
    {
        public static string Regex_IVE4 = @"([\w]+)@([\w]+)\.([\w][\w][\w])$";

        public bool validateIVE4(string IVE4)
        {
            return Regex.IsMatch(IVE4, Regex_IVE4);
        }
    }

}
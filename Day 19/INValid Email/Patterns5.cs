using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class Patterns5
    {
        public static string Regex_IVE5 = @"([\w]+)@([\w]+)\.([\w][\w][\w])\.([\w][\w][\w])$";

        public bool validateIVE5(string IVE5)
        {
            return Regex.IsMatch(IVE5, Regex_IVE5);
        }
    }

}
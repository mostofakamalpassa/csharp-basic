using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public class StringExtensions
    {
        public static bool IsValidEmail(string input)
        {
            // use a simple regular expression to check
            // that the input string is a valid email
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}

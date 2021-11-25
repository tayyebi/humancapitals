using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App
{
    class IntExtensions
    {
        private static Regex digitsOnly = new Regex(@"[^\d]");
        public static string DigitsOnly(string inp)
        {
            return digitsOnly.Replace(inp, string.Empty);
        }
    }
}

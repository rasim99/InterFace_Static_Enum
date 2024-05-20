using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeExtensionOfString_Task
{
    internal static class CapitalizeExtension
    {
        public static string CapitalizedString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new Exception("Cannot capitalized please enter character(s)");
            }
            StringBuilder capitalizedStr = new StringBuilder();
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in words)
            {

                capitalizedStr.Append(char.ToUpper(item[0]) + item.Substring(1));
                capitalizedStr.Append(' ');
            }
            return capitalizedStr.ToString();
        }
    }
}

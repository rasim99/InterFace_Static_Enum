using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExtension_Task
{
    internal static class ExtensionOfDateTime
    {
        public static int CalculateAge(this DateTime birthDate)
        {
            DateTime toDay=DateTime.Today;
            int age=toDay.Year-birthDate.Year;
            if (toDay < birthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}

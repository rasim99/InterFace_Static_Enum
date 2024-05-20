using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageMetodForIntArrTask
{
    internal static class AvarageArr
    {
        public static int CalculateAvarageOfArr(this int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new Exception("Array cannot be null or empty");
            }
            
            return arr.Sum()/arr.Length;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils_Task
{
    internal static class MathUtils
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) 
            {
                return false;
            }
            if (number==2)
            {
                return true;
            }
            if (number%2==0)
            {
                return false; 
            }
            for (int i = 3; i <= Math.Sqrt(number); i+=2)
            {
              if(number%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

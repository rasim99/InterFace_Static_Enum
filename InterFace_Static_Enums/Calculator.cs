using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace_Static_Enums
{
    internal class Calculator : ICalculator
    {
        public double? Divide(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new Exception("cannot divide to zero");

                }

                return (double) a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public int Multiply(int a, int b)
        {
            return a*b;
        }

        public int Substract(int a, int b)
        {
            return a-b;
        }

        public int Sum(int a, int b)
        {
            return a+b;
        }
    }
}

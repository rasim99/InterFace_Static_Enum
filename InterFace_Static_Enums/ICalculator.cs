using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace_Static_Enums
{
    internal  interface ICalculator
    {
        int Sum(int a, int b);
        int Substract(int a, int b);
        int Multiply(int a, int b);
        double? Divide(int a, int b);
    }
}

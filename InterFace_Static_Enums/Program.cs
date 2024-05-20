namespace InterFace_Static_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator();
            Initaliize: Console.WriteLine("choose operator : 1-Additonal 2-Substraction 3-Multiplitacion 4-Divider");
         int _operator=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter first num");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num");
            int num2 =Convert.ToInt32(Console.ReadLine());
            switch (_operator)
            {
                    case(int) CaculatedMethods.Additional:
                    Console.WriteLine(calculator.Sum(num1, num2));
                    break;
                    case (int)CaculatedMethods.Substraction:
                    Console.WriteLine(calculator.Substract(num1, num2));
                    break;
                    case (int)CaculatedMethods.Multiplitacion:
                    Console.WriteLine(calculator.Multiply(num1, num2));
                    break;
                    case (int)CaculatedMethods.Divider:
                    Console.WriteLine(calculator.Divide(num1, num2));
                    break;
                default:
                    Console.WriteLine("wrong operator");
                    goto Initaliize;
            }
        }
    }
}

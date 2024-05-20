namespace MonthsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initalize: Console.WriteLine("enter number of month (1-2)");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());
          
            Months months = (Months)MonthNumber;
            
            switch (months)
                {
                    case Months.Yanvar:
                        Console.WriteLine("Yanvar qis ayi");
                        break;
                    case Months.Fevral:
                        Console.WriteLine("Fevral qis ayi");
                        break;
                    case Months.Mart:
                        Console.WriteLine("Mart yaz ayi");
                        break;
                    case Months.Aprel:
                        Console.WriteLine("Aprel yaz ayi");
                        break;
                    case Months.May:
                        Console.WriteLine("May yaz ayi");
                        break;
                    case Months.Iyun:
                        Console.WriteLine("Iyun yay ayi");
                        break;
                    case Months.Iyul:
                        Console.WriteLine("Iyul yay ayi");
                        break;
                    case Months.Avqust:
                        Console.WriteLine("Avqust yay ayi");
                        break;

                    case Months.Sentyabr:
                        Console.WriteLine("Sentyabr payiz ayi");
                        break;
                    case Months.Oktyabr:
                        Console.WriteLine("Oktyabr payiz ayi");
                        break;
                    case Months.Noyabr:
                        Console.WriteLine("Noyabr payiz ayi");
                        break;
                    case Months.Dekabr:
                        Console.WriteLine("Dekabr qis ayi");
                        break;
                    default:
                    Console.WriteLine("wrong number");
                    goto Initalize;
                }
            
            
        }
    }
}

using BusinessLogic;

namespace Calculator.Console
{
    class Program
    {
        static void Main()
        {
            decimal d = 3.1M;
            System.Console.WriteLine((d % 1) == 0);
            d = 3.0M;
            System.Console.WriteLine((d % 1) == 0);
        }
    }
}

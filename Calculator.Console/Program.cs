using BusinessLogic;

namespace Calculator.Console
{
    class Program
    {
        static void Main()
        {
            InputOutput io = new InputOutput();

            System.Console.WriteLine(io.PerformCalculation());
        }
    }
}

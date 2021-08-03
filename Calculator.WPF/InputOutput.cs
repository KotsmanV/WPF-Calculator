using System;

namespace BusinessLogic
{
    public class InputOutput
    {
        private readonly DataProcessing dp = new DataProcessing();
        private readonly Calculation calc = new Calculation();

        private double Temp { get; set; }
        private string Symbol { get; set; }
        private double Result { get; set; }

        private double GetNumericInput()
        {
            Console.WriteLine("Input a number");
            string input = Console.ReadLine();
            while (!double.TryParse(input, out double result))
            {
                Console.Write("Input not acceptable, input a number: ");
                input = Console.ReadLine();
            }
            return double.Parse(input);
        }

        private string GetCalcSymbol()
        {
            Console.WriteLine("Input a calculation symbol");
            string input = Console.ReadLine();
            while (!(input.Equals("+") || input.Equals("-") || input.Equals("*") || input.Equals("/") || input.Equals("=")))
            {
                Console.Write("Input not acceptable, input a correct symbol: ");
                input = Console.ReadLine();
            }
            return input;
        }

        public double PerformCalculation()
        {
            Result = GetNumericInput();
            Symbol = GetCalcSymbol();

            while (!Symbol.Equals("="))
            {
                Temp = GetNumericInput();
                switch (Symbol)
                {
                    case "+": Result = dp.SimpleCalculation(Result, Temp, calc.Addition);break ;
                    case "-": Result = dp.SimpleCalculation(Result, Temp, calc.Subtraction); break;
                    case "*": Result = dp.SimpleCalculation(Result, Temp, calc.Multiplication); break;
                    case "/": Result = dp.SimpleCalculation(Result, Temp, calc.Division); break;
                }
                Console.WriteLine(Result);
                Symbol = GetCalcSymbol();
            }
            return Result;
        }


    }
}

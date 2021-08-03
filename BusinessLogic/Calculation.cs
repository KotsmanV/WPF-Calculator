using System;

namespace BusinessLogic
{
    public class Calculation
    {
        public Func<double, double, double> Addition = (x, y) => x + y;
        public Func<double, double, double> Subtraction = (x, y) => x - y;
        public Func<double, double, double> Multiplication = (x, y) => x * y;
        public Func<double, double, double> Division = (x, y) => y!=0 ?  x / y : throw new DivideByZeroException();
        public Func<double, double> SquareRoot = x => Math.Sqrt(x);
        public Func<double, double, double> Power = (x, y) => Math.Pow(x, y);

    }
}

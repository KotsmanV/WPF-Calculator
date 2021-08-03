using System;

namespace BusinessLogic
{
    public class DataProcessing
    {
        public double SimpleCalculation(double x, double y, Func<double, double,double> Calculation)
        {
            return Calculation.Invoke(x, y);
        }


    }
}

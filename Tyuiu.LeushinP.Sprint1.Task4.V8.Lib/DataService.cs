using System;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.LeushinP.Sprint1.Task4.V8.Lib
{
    public class DataService : ISprint1Task4V8
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sqrt(x - y) + 3 * x;
            double denominator = 3 + Math.Abs(x);

            return numerator / denominator;
        }
    }
}
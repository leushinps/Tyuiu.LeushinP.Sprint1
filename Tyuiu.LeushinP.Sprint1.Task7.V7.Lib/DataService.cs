using System;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.LeushinP.Sprint1.Task7.V7.Lib
{
    public class DataService : ISprint1Task7V7
    {
        public double Calculate(double x, double y)
        {

            double n = 5; 


            double denominator = n - 2 * Math.Pow(y, x);
            if (Math.Abs(denominator) < 0.000001)
            {
                throw new ArgumentException("Деление на ноль: знаменатель (n - 2y^x) равен нулю");
            }


            if (y < 0 && x != (int)x)
            {
                throw new ArgumentException("Недопустимые значения: отрицательное y с нецелым x");
            }

            double numerator = Math.Cos(x);
            double part1 = numerator / denominator;
            double part2 = 16 * x * Math.Cos(x * y);

            double result = part1 + part2 - 2;

            return Math.Round(result, 3);
        }
    }
}
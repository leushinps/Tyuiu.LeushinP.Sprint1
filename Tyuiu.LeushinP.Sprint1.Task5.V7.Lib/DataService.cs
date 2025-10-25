using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LeushinP.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            if (f <= 0 || f >= 360)
            {
                throw new ArgumentException("Угол f должен быть в диапазоне (0, 360)");
            }

            double hours = f / 30.0;
            return (int)hours;
        }
    }
}

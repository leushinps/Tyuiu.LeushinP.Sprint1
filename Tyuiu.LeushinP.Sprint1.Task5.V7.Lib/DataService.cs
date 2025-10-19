using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LeushinP.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double x)
        {
            if (x < 0 || x >= 360)
                throw new ArgumentException("Угол должен быть в диапазоне от 0 до 360");
            double totalHours = x / 30.0;
            int hours = (int)totalHours;

            return hours;
        }
    }
}
using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LeushinP.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            if (f <= 0 || f >= 360)
                throw new ArgumentException("Угол должен быть в диапазоне: 0 < f < 360");

            double totalHours = f / 30.0;


            return (int)totalHours;
        }

        public (int hours, int minutes, int seconds) CalculateTimeComponents(double f)
        {
            double totalHours = f / 30.0;

            int hours = (int)totalHours;
            double fractionalHours = totalHours - hours;
            int minutes = (int)(fractionalHours * 60);
            double fractionalMinutes = fractionalHours * 60 - minutes;
            int seconds = (int)(fractionalMinutes * 60);

            return (hours, minutes, seconds);
        }
    }
}
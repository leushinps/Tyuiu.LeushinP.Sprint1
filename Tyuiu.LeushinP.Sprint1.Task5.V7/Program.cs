using System;
using Tyuiu.LeushinP.Sprint1.Task5.V7.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Леушин П.С | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                               *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | СМАРТб-25-1                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток         *");
            Console.WriteLine("* (в первой половине дня), когда часовая стрелка повернулась на f градусов *");
            Console.WriteLine("* (0<f<360, f – вещественное число).                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите угол поворота часовой стрелки f (0 < f < 360):");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            try
            {
                int result = ds.AngleToHoursMinutes(x);
                Console.WriteLine($"Полное количество часов: {result}");
            }
            catch (ArgumentException oh)
            {
                Console.WriteLine($"Ошибка: {oh.Message}");
            }
            catch (Exception oh)
            {
                Console.WriteLine($"Произошла ошибка: {oh.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу...                                   ");
        }
    }
}
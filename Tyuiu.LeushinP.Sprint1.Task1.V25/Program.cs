using System;
using Tyuiu.LeushinP.Sprint1.Task1.V25.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "* Спринт #1 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                  *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Условие:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные   *");
            Console.WriteLine("* вычисляет результат по формуле (x*y)/(1+x) и печатает его на экране.     *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Исходные данные:                                                         *");
            Console.WriteLine("****************************************************************************");


            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
using System;
using Tyuiu.LeushinP.Sprint1.Task2.V25.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                      *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Известен угол в радианах. Перевести угол в градусы.                      *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите угол в радианах (целое число):");
            int radians = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double degrees = ds.ConvertRadsToDegrees(radians);
            Console.WriteLine($"{radians} радиан = {degrees} градусов");

            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу...                                     ");
            Console.ReadKey();
        }
    }
}
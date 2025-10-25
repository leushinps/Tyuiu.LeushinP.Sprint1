using Tyuiu.LeushinP.Sprint._1.Task0.V26.Lib;

namespace Tyuiu.LeushinP.Sprint1.V26
{
    class Program

    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "* Спринт #1 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #26                                                              *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Условие:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 4*5/2-18/2/3             *");
            Console.WriteLine("* и печатает результат на экране.                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Исходные данные:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");





            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }


    }
}
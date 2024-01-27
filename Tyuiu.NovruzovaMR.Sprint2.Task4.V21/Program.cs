using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NovruzovaMR.Sprint2.Task4.V21.Lib;

namespace Tyuiu.NovruzovaMR.Sprint2.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнил: Новрузова М. Р. | АСОиУб-23-3 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Новрузова М. Р. | АСОиУб-23-3                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значения с клавиатуры     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Переменная X = " + x);
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Переменная Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
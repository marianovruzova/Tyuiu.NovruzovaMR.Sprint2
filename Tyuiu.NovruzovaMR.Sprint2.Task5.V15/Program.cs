using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovruzovaMR.Sprint2.V15.Lib;

namespace Tyuiu.NovruzovaMR.Sprint2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №2 | Выполнил: Новрузова М. Р. | АСОиУБ-23-3 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Новрузова М. Р. | АСОиУБ-23-3                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким          *");
            Console.WriteLine("* днем недели (понедельником, вторником, …, субботой или воскресеньем)    *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января понедельник.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер дня: ");
            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numDay < 1) || (numDay > 365))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "День недели = " + ds.FindDayName(numDay);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
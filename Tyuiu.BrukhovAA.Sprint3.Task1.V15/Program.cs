using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint3.Task1.V15.Lib;

namespace Tyuiu.BrukhovAA.Sprint3.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Брюхов А. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла for                                               *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл while, которая                       *");
            Console.WriteLine("* вычисляет произведение ряда по формуле, при x=2                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double value = 2;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("Переменная x = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}

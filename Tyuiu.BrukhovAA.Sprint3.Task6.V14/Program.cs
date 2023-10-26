using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint3.Task6.V14.Lib;

namespace Tyuiu.BrukhovAA.Sprint3.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Брюхов А. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                               *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #14                                                            *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих      *");
            Console.WriteLine("* числовому отрезку [7, 16] количество всех делителей больше 5           *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue1 = 7;
            int stopValue1 = 16;

            Console.WriteLine("Старт шага  = " + startValue1);
            Console.WriteLine("Конец шага  = " + stopValue1);



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Количество делителей больших 5 = " + ds.GetSumTheDivisors(startValue1, stopValue1));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint5.Task0.V25.Lib;

namespace Tyuiu.KrutikovaVP.Sprint5.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить     *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.               *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}

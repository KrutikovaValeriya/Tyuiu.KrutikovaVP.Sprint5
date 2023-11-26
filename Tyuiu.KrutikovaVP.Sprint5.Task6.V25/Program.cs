using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint5.Task6.V25.Lib;

namespace Tyuiu.KrutikovaVP.Sprint5.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка файлов                                                   *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V25.txt                      *");
            Console.WriteLine("* в котором есть набор значений.                                           *");
            Console.WriteLine("* Найти количество знаков восклицания в заданной строке.                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";
            Console.WriteLine("данные находятся в файле: " + path);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество знаков восклицания = {res}");

            Console.ReadKey();
        }
    }
}

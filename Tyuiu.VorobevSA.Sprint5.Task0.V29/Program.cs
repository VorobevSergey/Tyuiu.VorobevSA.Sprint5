using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint5.Task0.V29.Lib;


namespace Tyuiu.VorobevSA.Sprint5.Task0.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:Оператор цикла continue/break                                      *");
            Console.WriteLine("* Задание #5.0                                                            *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x)=6.1x^3+0.23x^2+1.04x , вычислить его значение       *");
            Console.WriteLine("* при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt и   *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;

            Console.WriteLine("x=" + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = service1.SaveToFileTextData(x);

            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}

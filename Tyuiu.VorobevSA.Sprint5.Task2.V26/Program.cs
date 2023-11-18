using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint5.Task2.V26.Lib;

namespace Tyuiu.VorobevSA.Sprint5.Task2.V26
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
            Console.WriteLine("* Задание #5.2                                                            *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значен *");
            Console.WriteLine("* иями с клавиатуры. Заменить положительные элементы массива на 1, отриц  *");
            Console.WriteLine("* ательные на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести *");
            Console.WriteLine("* на консоль.                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите колличество строк массива: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] m = new int[r, c];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Введите{i},{j}элемент массива");
                    m[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{m[i, j]}\t");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = service1.SaveToFileTextData(m);

            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}

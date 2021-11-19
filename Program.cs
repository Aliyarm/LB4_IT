using System;

namespace LB4_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 6];
            Random ran = new();
            // создание массива с размерномтью [5, 6]

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++) 
                {
                    matrix[i, j] = ran.Next(0, 100); // заполнение массива случайными числами
                    Console.Write("{0}\t", matrix[i, j]); // вывод элемента массива с индексом [i, j] с табуляцией
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Все нечётные стоблцы:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j += 2)
                {
                    Console.Write("{0}\t", matrix[i, j]); // вывод всех столбцов, с которыми будут проводиться изменения
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int count = 0; // инициализируем счётчик, отвечающий за выполнение тела if
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j +=2)
                {
                        int mod = matrix[i, j] % (j + 1);
                        if (mod != 0)
                        {
                            matrix[i, j] = mod; // приравнивание нужного элемента к остатку от целочисленного деления
                            count++;
                        }
                        Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Количество изменённых элементов: " + count);
        }
    }
}
using System;

namespace LB4_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 6];
            Random ran = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = ran.Next(0, 100);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j % 2 == 0)
                    {
                        int mod = matrix[i, j] % (j + 1);
                        if (mod != 0)
                        {
                            matrix[i, j] = mod;
                            count++;
                        }
                        Console.Write("{0}\t", matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество изменённых элементов: " + count);
        }
    }
}
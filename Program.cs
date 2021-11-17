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
                    matrix[i, j] = ran.Next(-100, 100);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }

            //{ { 0, 1, 2, 3, 4 }, { 3, 4, 5, 9, 17 }, { 8, 9, 17, 12, 34 }, { 0, -2, -6, 15, -28 }, { -5, 8, 10, 0, 9 }, { 7, 21, 27, 3, 4 } };
        }
    }
}
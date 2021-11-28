using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = 1 - (i + j) % 2;
                    Console.Write("{0,4} ", array[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}


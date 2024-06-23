using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lowLimitRandom = 1;
            int highLimitRandom = 9;

            int maxNumber = 0;

            int[,] array = new int[10, 10];

            Console.WriteLine("Исходная матрица:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(lowLimitRandom, highLimitRandom + 1);

                    Console.Write(array[i, j] + " ");

                    if (array[i, j] > maxNumber)
                    {
                        maxNumber = array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Наибольший элемент в этой матрице равняется {maxNumber}");
            Console.WriteLine("Полученная матрица:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == maxNumber)
                    {
                        array[i, j] = 0;
                    }

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = GenerateMatrix(5, 5, 20);
            DrawMatrix(matrix);
            MaxSum(matrix);
            Console.ReadLine();
        }

        public static int[,] GenerateMatrix(int x, int y, int maxRandom = 10)
        {
            int[,] matrix = new int[x, y];
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rnd.Next(0, maxRandom);
                }
            }
            return matrix;
        }

        public static void MaxSum(int[,] matrix)
        {
            int[] temp = new int[matrix.GetLength(0)];

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    temp[j] += matrix[i, j];
                }
                Console.Write(temp[j] + " ");
            }
            
            int max = int.MinValue;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > max)
                {
                    max = temp[i];
                }
            }
            int index = Array.IndexOf(temp, max);
            Console.WriteLine();
            Console.WriteLine($"Max Sum in Coloumn: # {index+1}");
        }

        public static void DrawMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{(matrix[i, j].ToString().Length < 2 ? matrix[i, j].ToString() + "  |" : matrix[i, j].ToString() + " |")}");
                }
                Console.WriteLine();
            }
        }
    }
}
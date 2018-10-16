using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Matrix_2d
    {
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

        public static int GetSumOdd(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        sum += matrix[i,j];
                    }
                }
            }
            return sum;
        }

        public static int GetSumEven(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}

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
            var matrix = Matrix.GenerateMatrix(10, 10, 10);
            Matrix.DrawMatrix(matrix);
            GetMinValue(matrix);   
            Console.ReadLine();
        }


        public static void GetMinValue(int[,] matrix)
        {
            int[] minValue = new int [10];
            int a;            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                a = int.MaxValue;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (a > matrix[i, j])
                    {
                        a = matrix[i, j];
                    }
                    
                }
                minValue[i] = a;
                Console.WriteLine($"Min Value #{i+1}: {minValue[i]}");
            }

        }

    }
}

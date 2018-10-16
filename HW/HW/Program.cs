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
            var matrix = Matrix_2d.GenerateMatrix(2, 3);
            Matrix_2d.DrawMatrix(matrix);
            Console.Write($"Even: {Matrix_2d.GetSumEven(matrix)}");
            Console.WriteLine();
            Console.Write($"Odd: {Matrix_2d.GetSumOdd(matrix)}");
            Console.WriteLine();
            Console.WriteLine();

            var array = Array_new.GenerateArray(5);
            Array_new.DrawArray(array);
            Console.WriteLine();
            Console.Write($"Even: {Array_new.GetSumEven(array)}");
            Console.WriteLine();
            Console.Write($"Odd: {Array_new.GetSumOdd(array)}");

            Console.ReadLine();
        }
    }
}

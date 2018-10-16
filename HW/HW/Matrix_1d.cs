using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Array_new
    {
        public static int[] GenerateArray (int x, int maxRandom = 10)
        {
            int[] array = new int[x];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, maxRandom);
            }
            return array;
        }

        public static void DrawArray (int[] array)
        {
            Console.Write('[');
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write(']');
        }

        public static int GetSumOdd (int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 != 0)
                {
                    sum += array[i];
                }

            }
            return sum;
        }

        public static int GetSumEven(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }

            }
            return sum;
        }
    }
}

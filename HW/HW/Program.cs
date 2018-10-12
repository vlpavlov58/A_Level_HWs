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
                Random random = new Random();
                int[,] heatmap = new int[10, 10];

                for (int i = 0; i < heatmap.GetLength(0); i++)
                {

                    for (int j = 0; j < heatmap.GetLength(1); j++)

                    {
                        heatmap[i, j] = random.Next(0, 10);
                    }

                }

                for (int i = 0; i < heatmap.GetLength(0); i++)
                {
                    for (int j = 0; j < heatmap.GetLength(1); j++)
                    {
                        if (heatmap[i, j] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write('█');
                        }
                        else if (heatmap[i, j] >= 1 && heatmap[i, j] <= 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write('█');
                        }
                        else if (heatmap[i, j] >= 4 && heatmap[i, j] <= 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write('█');
                        }
                        else if (heatmap[i, j] >= 7 && heatmap[i, j] <= 8)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write('█');
                        }
                        else if (heatmap[i, j] >= 9 && heatmap[i, j] <= 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('█');
                        }
                    }
                    Console.ReadLine();

                }
            }
        }
    }

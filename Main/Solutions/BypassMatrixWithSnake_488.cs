using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class BypassMatrixWithSnake_488 : SolutionBase
    {
        internal override void Invoke()
        {
            string[] tokens = Console.ReadLine().Split();
            int n = int.Parse(tokens[0]);

            int[,] numbers = new int[n, n];
            int element = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        numbers[i, j] = element;
                        element++;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        numbers[i, j] = element;
                        element++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}

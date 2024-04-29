using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class UseSubProgram_913 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = int.Parse(Console.ReadLine());

            double[,] matrix = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                string token = Console.ReadLine();
                matrix[i, 0] = double.Parse(token.Split()[0]);
                matrix[i, 1] = double.Parse(token.Split()[1]);
   
            }


            for (int i = 0; i < n; i++)
            {
               
                Console.WriteLine("{0:F4} {1:F4}",
                    matrix[i, 0] + matrix[i, 1], matrix[i, 0] * matrix[i, 1]);
            }
        }
    }
}

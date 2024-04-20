using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class SumOfTwo_519 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, 2];
            List<int> sums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                matrix[i, 0] = int.Parse(tokens[0]);
                matrix[i, 1] = int.Parse(tokens[1]);
                sums.Add(matrix[i, 0] + matrix[i, 1]);

            }

            for (int i = 0; i < n; i++) Console.WriteLine(sums[i]);
        }
    }
}

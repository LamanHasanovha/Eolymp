using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class MaximumOfAbsoluteValues_914 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split();

            double[] numbers = new double[n];

            double max = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(tokens[i]);
                if (Math.Abs(numbers[i]) > max)
                {
                    max = Math.Abs(numbers[i]);
                }
            }

            Console.WriteLine("{0:N2}", max);
        }
    }
}

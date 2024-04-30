using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class TwiceTheMinimum_917 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] tokens = Console.ReadLine().Split();

            double[] numbers = new double[n];
            double min = 100;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(tokens[i]);
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            min *= 2;

            Console.WriteLine("{0:N2}", min);
        }
    }
}

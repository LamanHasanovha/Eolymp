using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class TheArithmeticMeanOfPositive_910 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbers = Array.ConvertAll(Console.ReadLine().Split(), num => double.Parse(num));

            int count = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("Not Found");
            else
            {
                double result = sum / count;
                Console.WriteLine("{0:N2}", result);
            }

        }

    }
}

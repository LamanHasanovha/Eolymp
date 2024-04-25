using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class TheFirstIsNotGreaterFor_907 : SolutionBase
    {
        internal override void Invoke()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string[] tokens = Console.ReadLine().Split();

            double[] numbers = new double[n];

            int index = -1;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(tokens[i]);
                if (numbers[i] <= 2.5)
                {
                    index = i + 1;
                    Console.WriteLine("{0} {1:N2}", index, numbers[i]);
                    break;
                }
            }

            if (index == -1) Console.WriteLine("Not Found");
        }
    }
}

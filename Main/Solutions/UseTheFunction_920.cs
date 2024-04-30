using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class UseTheFunction_920 : SolutionBase
    {
        internal override void Invoke()
        {
             static double MinThree(double a, double b, double c)
            {
                double min;
                if (a <= b && a <= c)
                {
                    min = a;
                }
                else if (b <= a && b <= c)
                {
                    min = b;
                }
                else min = c;

                return min;
            }
            static void Main(string[] args)
            {
                string[] tokens = Console.ReadLine().Split();
                double x = double.Parse(tokens[0]);
                double y = double.Parse(tokens[1]);
                double z = double.Parse(tokens[2]);

                double min = MinThree(Math.Max(x, y), Math.Max(y, z), x + y + z);

                Console.WriteLine("{0:N2}", min);
            }
        }
    }
}

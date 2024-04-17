using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class FourCircles_269 : SolutionBase
    {
        internal override void Invoke()
        {

            string[] tokens = Console.ReadLine().Split();
            double a = double.Parse(tokens[0]);
            double b = double.Parse(tokens[1]);
            double c = double.Parse(tokens[2]);

            double n = Math.Sqrt(a * b * c * (a + b + c));
            double radius = (a * b * c) / (2 * n + (a * b + b * c + a * c));

            Console.WriteLine("{0:F4}", radius);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class QuadraticEquation_911 : SolutionBase
    {
        internal override void Invoke()
        {
            string[] strings = Console.ReadLine().Split();
            double a= double.Parse(strings[0]), b= double.Parse(strings[1]),c=double.Parse(strings[2]);
            double d = disc(a, b, c);
            double two = 2;
            if (d < 0) Console.WriteLine("No roots"); 
            else if (d == 0)
            {
                double x = (-b) / (two * a);
                Console.WriteLine("One root: " + x.ToString());
            }
            else
            {
                double x1 = (-b - Math.Sqrt(d)) / (two * a);
                double x2 = (-b + Math.Sqrt(d)) / (two * a);

                Console.WriteLine("Two roots: " + Math.Min(x1, x2).ToString() + " " + Math.Max(x1, x2).ToString());
            }
        }

        double disc(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}

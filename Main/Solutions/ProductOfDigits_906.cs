using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class ProductOfDigits_906 : SolutionBase
    {
        internal override void Invoke()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0) a *= -1;
            int b = a % 10;
            int c = a / 100;
            int d = a / 10 % 10;
            int cem = b * c * d;
            Console.WriteLine(cem);
        }
    }
}

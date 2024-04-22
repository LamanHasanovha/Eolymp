using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class FirstOrLast_903 : SolutionBase
    {
        internal override void Invoke()
        {
            int abc = int.Parse(Console.ReadLine());

            int a = abc / 100;
            int c = abc % 10;

            if (a > c) Console.WriteLine(a);
            else if (c > a) Console.WriteLine(c);
            else Console.WriteLine("=");
        }
    }
}

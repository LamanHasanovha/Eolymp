using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class Cash_Machine_138 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 10 || n % 10 != 0) Console.WriteLine(-1);
            else
            {
                int m500 = n / 500;
                n -= m500 * 500;

                int m200 = n / 200;
                n -= m200 * 200;

                int m100 = n / 100;
                n -= m100 * 100;

                int m50 = n / 50;
                n -= m50 * 50;

                int m20 = n / 20;
                n -= m20 * 20;

                int m10 = n / 10;
                n -= m10 * 10;
                Console.WriteLine(m500 + m200 + m100 + m50 + m20 + m10);
            }   
        }
    }
}

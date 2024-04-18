using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class Transformation_388 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    count++;
                    n /= 2;
                }
                else
                {
                    count++;
                    n += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}

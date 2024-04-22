using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class Ones_622 : SolutionBase
    {
        internal override void Invoke()
        {
            string[] tokens = Console.ReadLine().Split();
            int n = int.Parse(tokens[0]);
            int say = 0;
            while (n != 0)
            {

                if (n % 2 != 0) say++;
                n /= 2;
            }
            Console.WriteLine(say);

        }
    }
}

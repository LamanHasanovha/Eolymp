using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class Zoo_157 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((n - 1) * (n - 2));

        }
    }
}

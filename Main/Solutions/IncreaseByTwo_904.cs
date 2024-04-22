using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class IncreaseByTwo_904 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = Array.ConvertAll
                (Console.ReadLine().Split(), num => int.Parse(num));

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] >= 0) numbers[i] += 2;
            }

            Console.WriteLine(string.Join(' ', numbers));  // 1 2 3 4 
        }
    }
}

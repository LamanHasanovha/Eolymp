using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class NumberOfWords_329 : SolutionBase
    {
        internal override void Invoke()
        {

            string text = Console.ReadLine();

            Console.WriteLine(text.Split(new[] { ',', '.', ' ', '?', '!', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries).Length);
        }
    }
}

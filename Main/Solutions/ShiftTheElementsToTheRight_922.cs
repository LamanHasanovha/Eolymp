using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class ShiftTheElementsToTheRight_922 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(tokens[i]);
            }

            int[] changedNumbers = new int[n];
            changedNumbers[0] = numbers[n - 1];

            int iteration = 0;
            for (int i = 1; i < n; i++, iteration++)
            {
                changedNumbers[i] = numbers[iteration];

                Console.Write(changedNumbers[iteration] + " ");
            }

            Console.WriteLine(changedNumbers[n - 1]);
        }
    }
}

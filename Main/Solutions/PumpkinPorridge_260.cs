using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class PumpkinPorridge_260 : SolutionBase
    {
        internal override void Invoke()
        {
            string[] tokens = Console.ReadLine().Split();
            int[] numbers = new int[tokens.Length - 1];
            int count = 0;
            for (int i = 1; i < tokens.Length; i++, count++)
            {
                numbers[count] = int.Parse(tokens[i]);
            }

            int temp = 0;
            do
            {
                temp = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i + 1 < numbers.Length)
                    {
                        if (numbers[i] < numbers[i + 1])
                        {
                            numbers[i] += numbers[i + 1];
                            numbers[i + 1] = numbers[i] - numbers[i + 1];
                            numbers[i] -= numbers[i + 1];
                            temp++;
                        }
                    }
                }
                if (temp == 0) break;

            } while (temp != 0);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}

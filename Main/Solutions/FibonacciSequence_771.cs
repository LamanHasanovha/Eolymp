using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class FibonacciSequence_771 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger firstnumber = new BigInteger();
            BigInteger secondnumber = new BigInteger();
            BigInteger number = new BigInteger();
            firstnumber = 1;
            secondnumber = 1;

            int count = 2;
            number = 0;

            if (n == 1 || n == 2) Console.WriteLine(1);
            else
            {
                while (count != n)
                {
                    firstnumber += secondnumber;
                    count++;
                    if (count == n)
                    {
                        number = firstnumber;
                        break;
                    }
                    secondnumber += firstnumber;
                    count++;
                    if (count == n)
                    {
                        number = secondnumber;
                        break;
                    }
                }
                Console.WriteLine(number);
            }
        }
    }
}

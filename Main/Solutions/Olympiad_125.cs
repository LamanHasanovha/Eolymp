using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class Olympiad_125 : SolutionBase
    {
        //Simple Problem https://www.eolymp.com/en/problems/125
        internal override void Invoke()
        {
            string[] time1 = Console.ReadLine().Split();
            int h1 = int.Parse(time1[0]);
            int m1 = int.Parse(time1[1]);
            int s1 = int.Parse(time1[2]);
            string[] time2 = Console.ReadLine().Split();
            int h2 = int.Parse(time2[0]);
            int m2 = int.Parse(time2[1]);
            int s2 = int.Parse(time2[2]);

            int ht = h2 - h1;
            int mt = 0;
            int st = 0;


            if (s2 - s1 >= 0 && m2 - m1 >= 0)
            {
                st = s2 - s1;
                mt = m2 - m1;
            }

            else if (s2 - s1 < 0 && m2 - m1 >= 0)
            {
                st = s2 - s1 + 60;
                if (m2 - m1 - 1 >= 0)
                {
                    mt = m2 - m1 - 1;
                    ht = h2 - h1;
                }
                else
                {
                    mt = m2 - m1 - 1 + 60;
                    ht -= 1;
                }
            }

            else if (m2 - m1 < 0 && s2 - s1 >= 0)
            {
                st = s2 - s1;
                mt = m2 - m1 + 60;
                ht -= 1;
            }

            else if (s2 - s1 < 0 && m2 - m1 < 0)
            {
                st = s2 - s1 + 60;
                mt = m2 - m1 - 1 + 60;
                ht = h2 - h1 - 1;
            }



            Console.WriteLine(ht + " " + mt + " " + st);
        }
    }
}

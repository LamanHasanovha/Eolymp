using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Solutions
{
    internal class TheLevelOfEducationalAchievements_902 : SolutionBase
    {
        internal override void Invoke()
        {
            int a = int.Parse(Console.ReadLine());

            if (a <= 3)
            {
                Console.WriteLine("Initial");
            }
            else if (a <= 6)
            {
                Console.WriteLine("Average");
            }
            else if (a <= 9)
            {
                Console.WriteLine("Sufficient");
            }
            else Console.WriteLine("High");
        }
    }
}

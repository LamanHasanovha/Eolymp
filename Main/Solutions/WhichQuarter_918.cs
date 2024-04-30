namespace Main.Solutions
{
    internal class WhichQuarter_918 : SolutionBase
    {
        internal override void Invoke()
        {

            string[] tokens = Console.ReadLine().Split();
            double x = double.Parse(tokens[0]);
            double y = double.Parse(tokens[1]);

            if (x > 0 & y > 0)
            {
                Console.WriteLine(1);
            }
            else if (x < 0 & y > 0)
            {
                Console.WriteLine(2);
            }
            else if (x < 0 & y < 0)
            {
                Console.WriteLine(3);
            }
            else if (x == 0 | y == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
    }
}

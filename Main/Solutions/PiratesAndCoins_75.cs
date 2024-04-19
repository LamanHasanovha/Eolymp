namespace Main.Solutions
{
    internal class PiratesAndCoins_75 : SolutionBase
    {
        internal override void Invoke()
        {
            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);
            int n = 1;
            while (m > 0)
            {
                m = m - a;
                a++;
                n++;
            }
            Console.WriteLine(n - 2);
        }
    }
}

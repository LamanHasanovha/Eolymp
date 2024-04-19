namespace Main.Solutions
{
    internal class SumOfSquares_519 : SolutionBase
    {
        internal override void Invoke()
        {
            string[] tokens = Console.ReadLine().Split();
            decimal a1 = decimal.Parse(tokens[0]);
            decimal a2 = decimal.Parse(tokens[1]);
            Console.WriteLine(a1 * a1 + a2 * a2);
        }
    }
}

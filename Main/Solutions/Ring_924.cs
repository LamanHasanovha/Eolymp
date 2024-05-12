namespace Main.Solutions;

internal class Ring_924 : SolutionBase
{
    internal override void Invoke()
    {
        string[] tokens = Console.ReadLine().Split();
        double hs = double.Parse(tokens[0]);
        double r1 = double.Parse(tokens[1]);

        double s = Math.Pow(r1, 2) * Math.PI;

        double s2 = s - hs;

        double r2 = Math.Sqrt(s2 / Math.PI);

        Console.WriteLine("{0:N2}", r2);
    }
}

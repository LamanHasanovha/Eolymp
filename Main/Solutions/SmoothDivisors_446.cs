namespace Main.Solutions
{
    internal class SmoothDivisors_446 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int say = 0;
            for (int i = 1; i < n; i++)
            {
                if (n / i == n % i)
                {
                    say = say + 1;
                }
            }
            Console.WriteLine(say);
        }
    }
}

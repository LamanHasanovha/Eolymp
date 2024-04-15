namespace Main.Solutions
{
    internal class Digits_2 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int say = 0;
            if (n == 0) Console.WriteLine(1);
            else
            {
                while (n != 0)
                {
                    n /= 10;
                    say++;
                }

                Console.WriteLine(say);
            }
        }
    }
}

namespace Main.Solutions
{
    internal class NumberByThree_919 : SolutionBase
    {
        internal override void Invoke()
        {
            int n = int.Parse(Console.ReadLine());

            double[] array = Array.ConvertAll
                (Console.ReadLine().Split(), r => double.Parse(r));

            int count = 0;
            double sum = 0;

            for (int i = 2; i < n; i += 3)
            {
                if (array[i] > 0)
                {
                    count++;
                    sum += array[i];
                }
            }

            Console.WriteLine("{0} {1:N2}", count, sum);
        }
    }
}

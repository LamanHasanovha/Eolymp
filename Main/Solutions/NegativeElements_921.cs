namespace Main.Solutions
{
    internal class NegativeElements_921 : SolutionBase
    {
        internal override void Invoke()
        {
            int h = Convert.ToInt32(Console.ReadLine());
            string[] eded = Console.ReadLine().Split();
            decimal[] A = new decimal[eded.Length];
            decimal count = 0;
            decimal a = 0.00m;
            for (int i = 0; i < eded.Length; i++)
            {
                A[i] = decimal.Parse(eded[i]);
            }
            foreach (var b in A)
            {
                if (b < 0)
                {
                    count++;
                    a += b;
                }
            }
            Console.WriteLine(count + " " + a);
        }
    }
}

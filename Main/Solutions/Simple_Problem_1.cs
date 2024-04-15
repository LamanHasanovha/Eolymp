namespace Main.Solutions
{
    internal class Simple_Problem_1 : SolutionBase
    {
        //Simple Problem https://www.eolymp.com/en/problems/1
        internal override void Invoke()
        {
            int number = int.Parse(Console.ReadLine());
            int dec = number / 10;
            int unit = number % 10;

            Console.WriteLine($"{dec} {unit}");

            Console.ReadLine();
        }
    }
}

namespace Main;

internal class Solutions
{   
    public static Solutions Instance => new();

    #region Simple Problem https://www.eolymp.com/en/problems/1

    public void SimpleProblem_1()
    {
        int number = int.Parse(Console.ReadLine());
        int dec = number / 10;
        int unit = number % 10;
        
        Console.WriteLine($"{dec} {unit}");

        Console.ReadLine();
    }
    #endregion

}


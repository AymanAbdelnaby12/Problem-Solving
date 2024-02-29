namespace test;

public class Ayman
{
    public int X { get; set; }
}


public class Program
{
    public static void Main(string[] args)
    {
        Ayman a1 = new Ayman();

        Console.WriteLine(a1.X);

        Console.ReadKey();
    }
}
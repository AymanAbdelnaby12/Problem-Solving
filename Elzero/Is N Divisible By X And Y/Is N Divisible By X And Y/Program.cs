
Console.WriteLine("please enter x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("please enter y");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("please enter n");
int n = int.Parse(Console.ReadLine());
if(n%x==0 && n % y == 0)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
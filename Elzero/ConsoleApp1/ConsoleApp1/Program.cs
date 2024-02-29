Console.WriteLine("please enter numer");
int r;
int x = int.Parse(Console.ReadLine());
if (x % 2 == 0)
{
    r = x * 8;
}
else
{
    r = x * 9;
}
Console.WriteLine(r);
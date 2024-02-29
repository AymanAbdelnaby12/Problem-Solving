Console.WriteLine("please enter numer");
int r;
int x = int.Parse(Console.ReadLine());
if (x % 100 == 0)
{
    r = x/100;
}
else
{
    r = (x/100)+1;
}
Console.WriteLine(r);
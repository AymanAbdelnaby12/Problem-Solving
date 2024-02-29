string revrsed = "";
Console.WriteLine("enter string");
string x=Console.ReadLine();
for(int i = x.Length - 1; i >= 0; i--)
{
    revrsed += x[i];
    
}
Console.WriteLine(revrsed);

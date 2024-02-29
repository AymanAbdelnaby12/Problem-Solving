using System.Diagnostics.Metrics;
string x = "hello";
char l = 'l';
int count = 0;
for (int i = 0; i < x.Length; i++)
{
    if (l == x[i])
    {
        count += 1;
    }
}
Console.Write(count);
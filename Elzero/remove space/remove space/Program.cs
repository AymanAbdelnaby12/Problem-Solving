string x = "sdfdgfhfg dsafm lpgotek kas";
string newString = "";
for (int i = 0; i < x.Length; i++)
{
    if (x[i] !=' ')
    {
        newString += x[i];
    }
}
Console.Write(newString);
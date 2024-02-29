//cin string
//for to length
//if conditin
//return string
string x = "efgb!g";
string newString = "";
for(int i = 0; i <x.Length; i++)
{
    if (x[i] !='!')
    {
        newString += x[i];
    }
    else { Console.WriteLine(0); }
}
Console.WriteLine(newString);
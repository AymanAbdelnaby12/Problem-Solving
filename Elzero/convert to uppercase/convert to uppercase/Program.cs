
public static class StringExtensions
{
    public static string ToAlternatingCase(this string input)
    {
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLower(characters[i]))
                characters[i] = char.ToUpper(characters[i]);
            else if (char.IsUpper(characters[i]))
                characters[i] = char.ToLower(characters[i]);
        }

        return new string(characters);
    }
}


class Program
{
    static void Main()
    {
        string input = "Hello World";
        string result = input.ToAlternatingCase();

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Alternating Case: " + result);
    }
}
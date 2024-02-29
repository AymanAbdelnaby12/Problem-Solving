
long[] arr = new long[];
string[] numbers = Console.ReadLine().Split(" ");
for (long i = 0; i < numbers.Length; i++)
{
    arr[i] = long.Parse(numbers[i]) * -1;
}
Console.WriteLine(arr);
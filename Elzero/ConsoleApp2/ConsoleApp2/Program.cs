using System;

namespace AdditiveInverse
{
    class Program
    {
        static int[] Inverse(int[] numbers)
        {
            int[] inverse = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                inverse[i] = -numbers[i];
            }

            return inverse;
        }

        static void Main()
        {
            Console.WriteLine("Enter a series of numbers (separated by spaces):");
            string input = Console.ReadLine();
            string[] number = input.Split(' ');

            int[] numbers = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                numbers[i] = int.Parse(number[i]);
            }

            int[] inverseNumbers = Inverse(numbers);
            for (int i = 0;i<=inverseNumbers.Length;i++)
            {
                Console.WriteLine(inverseNumbers[i]);
            }
        }
    }
}
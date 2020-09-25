using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            int[] inputCopy = input;
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < inputCopy.Length; j++)
                {
                    if (input[i] + inputCopy[j]== magicNumber)
                    {
                        result += input[i] +" "+ inputCopy[j];
                        Console.WriteLine(result);
                        result = "";
                    }
                }
            }
        }
    }
}

using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arr = Console.ReadLine().Split();

            //int count = int.Parse(Console.ReadLine());
            //for (int c = 0; c < count; c++)
            //{
            //    string temp = arr[0];
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        arr[i] = arr[i + 1];
            //    }
            //    arr[arr.Length - 1] = temp;

            //}
            //Console.WriteLine(string.Join(" ", arr));

            string[] input = Console.ReadLine().Split();
            int rotationNumber = int.Parse(Console.ReadLine());
            InputRotator(input, rotationNumber);
            Console.WriteLine(string.Join(" ", input));
        }

        private static void InputRotator(string[] input, int rotationNumber)
        {
            for (int i = 0; i < rotationNumber; i++)
            {
                string temp = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = temp;
            }
        }
    }
}

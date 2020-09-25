using System;
using System.Linq;

namespace LabArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day of weeks
            //string[] days = {"M", "Tus", "W", "Th", "F", "Su", "Sa"};
            //int day = int.Parse(Console.ReadLine());
            //if (day>=1&&day<=7)
            //{
            //    Console.WriteLine(days[day-1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");
            //}

            //PrintNumbersInReversedOrder
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[numbers.Length-i-1]+" ");
            //}
            //second decision with reversed loop:
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i]+ " ");
            //}

            //RoundingNumbers
            //double[] input = Console.ReadLine()
            //    .Split()
            //    .Select(double.Parse).ToArray();
            //double[] roundedNumbers = new double[input.Length];
            //for (int i = 0; i < roundedNumbers.Length; i++)
            //{
            //    roundedNumbers[i] = Math.Round(input[i], MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{input[i]} => {roundedNumbers[i]}");
            //}

            //ReverceArrayOfStrings
            //string[] input = Console.ReadLine().Split();
            //for (int i = 0; i < input.Length/2; i++)
            //{
            //    string temp = input[i];
            //    input[i] = input[input.Length - i - 1];
            //    input[input.Length - i - 1] = temp;
            //}
            //Console.WriteLine(string.Join(" ", input));

            //SumEvenNumbers
            //int[] numbers = Console.ReadLine()
            //    .Split().Select(int.Parse).ToArray();
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2==0)
            //    {
            //        sum += numbers[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //EvenAndOddSubstraction
            //        int[] numbers = Console.ReadLine()
            //.Split().Select(int.Parse).ToArray();
            //        int evenSum = 0;
            //        int oddSum = 0;
            //        int result = 0;
            //        for (int i = 0; i < numbers.Length; i++)
            //        {
            //            if (numbers[i]%2==0)
            //            {
            //                evenSum += numbers[i];
            //            }
            //            else
            //            {
            //                oddSum += numbers[i];
            //            }
            //        }
            //        result = evenSum - oddSum;
            //        Console.WriteLine(result);

            //EqualArrays
            //      int[] arr1 = Console.ReadLine()
            //.Split().Select(int.Parse).ToArray();
            //      int[] arr2 = Console.ReadLine()
            //.Split().Select(int.Parse).ToArray();
            //      int sum = 0;
            //      int i = 0;
            //      for (i = 0; i < arr1.Length; i++)
            //      {
            //          if (arr1[i]==arr2[i])
            //          {
            //              sum += arr1[i];
            //          }
            //          else
            //          {
            //              Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            //              break;
            //          }
            //      }
            //      if (i== arr1.Length)
            //      {
            //          Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //      }

            //CondenseArrayToNumber
            int[] nums = Console.ReadLine()
      .Split().Select(int.Parse).ToArray();

            int[] condensed = new int[nums.Length - 1];

            while (nums.Length > 1)
            {
                condensed = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length-1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}

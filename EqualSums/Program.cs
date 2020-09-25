using System;
using System.Linq;
namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
            //bool isFound = false;
            //for (int curr = 0; curr < arr.Length; curr++)
            //{
            //    int sumRight = 0;
            //    for (int i = curr + 1; i < arr.Length; i++)
            //    {
            //        sumRight += arr[i];
            //    }
            //    int sumLeft = 0;
            //    for (int i = curr - 1; i >= 0; i--)
            //    {
            //        sumLeft += arr[i];
            //    }
            //    if (sumRight == sumLeft)
            //    {
            //        Console.WriteLine(curr);
            //        isFound = true;
            //    }
            //}
            //if (isFound==false)
            //{
            //    Console.WriteLine("no");
            //}

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool IsFound = true;
            int leftSum = 0;
            int rightSum = 0;
            for (int curr = 0; curr < input.Length; curr++)
            {
                rightSum = 0;
                for (int i = curr+1; i < input.Length; i++)
                {
                    rightSum += input[i];
                }
                leftSum = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    leftSum += input[i];
                }
                if (rightSum== leftSum)
                {
                    IsFound = true;
                    Console.WriteLine(curr);
                    break;
                }

            }
            if (rightSum != leftSum)
            {
                IsFound = false;
                Console.WriteLine("no");
            }

        }
    }
}

using System;
using System.Linq;
namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine().Split()
            //    .Select(int.Parse)
            //    .ToArray();
            //int bestCount = 0;
            //int bestIndex = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int currElement = arr[i];
            //    int currentCounter = 1;
            //    for (int currI = i + 1; currI < arr.Length; currI++)
            //    {
            //        if (currElement == arr[currI])
            //        {
            //            currentCounter++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    if (currentCounter > bestCount)
            //    {
            //        bestCount = currentCounter;
            //        bestIndex = i;
            //    }
            //}
            //string result = "";
            //for (int i = 0; i < bestCount; i++)
            //{
            //    result += arr[bestIndex] + " ";
            //}
            //Console.WriteLine(result);

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bestCounter = 0;
            int bestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                int currCount = 1;
                for (int currI = i+1; currI < arr.Length; currI++)
                {
                    if (curr ==arr[currI])
                    {
                        currCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currCount>bestCounter)
                {
                    bestCounter = currCount;
                    bestIndex = i;
                }
            }
            string result = "";
            for (int i = 0; i < bestCounter; i++)
            {
                result += arr[bestIndex]+" ";
            }
            Console.WriteLine(result);
        }
    }
}



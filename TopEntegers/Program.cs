using System;
using System.Linq;
namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            //string result = "";
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int curr = arr[i];
            //    bool isTopInteger = true;
            //    for (int index = i + 1; index < arr.Length; index++)
            //    {
            //        if (curr <= arr[index])
            //        {
            //            isTopInteger = false;
            //            break;
            //        }
            //    }
            //    if (isTopInteger)
            //    {
            //        result += curr + " ";
            //    }
            //}
            //Console.WriteLine(result);

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                bool IsBigger = true;
                int curr = input[i];
                for (int j = i+1; j < input.Length; j++)
                {
                    if (curr>input[j])
                    {
                        IsBigger = true;
                    }
                    else
                    {
                        IsBigger = false;
                        break;
                    }
                }
                if (IsBigger)
                {
                    Console.Write(curr+" ");
                    //result += curr+ " ";
                }
            }
            //Console.WriteLine(result);
        }
    }
}

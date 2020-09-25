using System;

namespace ZigZgArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //string[] arrOne = new string[n];
            //string[] arrTwo = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    string[] current = Console
            //        .ReadLine()
            //        .Split();
            //    if (i%2==0)
            //    {
            //        arrOne[i] = current[0];
            //        arrTwo[i] = current[1];
            //    }
            //    else
            //    {
            //        arrOne[i] = current[1];
            //        arrTwo[i] = current[0];
            //    }
            //}
            //Console.WriteLine(string.Join(" ", arrOne));
            //Console.WriteLine(string.Join(" ", arrTwo));
            int n = int.Parse(Console.ReadLine());
            string result1 = "";
            string result2 = "";
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (i%2==0)
                {
                    result1 += input[0] + " ";
                    result2 += input[1] + " ";
                }
                else
                {
                    result1 += input[1] + " ";
                    result2 += input[0] + " ";
                }
            }
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}

using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] array1 = Console.ReadLine()
            //    .Split();
            //string[] array2 = Console.ReadLine()
            //    .Split();
            //string result = "";

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        if (array1[j]==array2[i])
            //        {
            //            result += array2[i]+" ";
            //        }
            //    }
            //}
            //Console.WriteLine(result);
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string curr = "";
            for (int i = 0; i < arr2.Length; i++)
            {
                curr = arr2[i];
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[j]== curr)
                    {
                        Console.Write(curr + " ") ;
                    }
                }
            }

        }
    }
}

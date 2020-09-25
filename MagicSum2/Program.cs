using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                for (int next = i+1; next < arr.Length; next++)
                {
                    int nextNum = arr[next];
                    if (curr+nextNum==magicNumber)
                    {
                        Console.WriteLine(curr+" "+nextNum);
                    }
                }
            }
        }
    }
}

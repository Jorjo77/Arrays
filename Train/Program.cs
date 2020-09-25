using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //int wagonsNumber = int.Parse(Console.ReadLine());
            //int[] train = new int[wagonsNumber];
            //for (int i = 0; i < wagonsNumber; i++)
            //{
            //    train[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //for (int i = 0; i < train.Length; i++)
            //{
            //    sum += train[i];
            //}
            //for (int i = 0; i < train.Length; i++)
            //{
            //    Console.Write(train[i]+" ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(sum); 
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sum);
        }
    }
}

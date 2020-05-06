using System;

namespace Lab3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Array Length:");

            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("M - manual set, R - random set");

            string info = (Console.ReadLine().ToLower());

            Console.WriteLine("Array is:");

            int[] arr = new int[length];

            int min = -100, max = 100, maxInArr = arr[0], maxInArrPos = 0, max5 = 0, sum = 0;

            Random rand = new Random();

            if (info == "r")
            {
                for (int i = 0; i < length; i++)
                {
                    arr[i] = rand.Next(min, max);

                    Console.WriteLine("---------" + "[" + i + "]" + " = " + arr[i]);
                }
            }
            else if (info == "m")
            {
                for (int i = 0; i < length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 5)
                {
                    max5++;

                }

            }
            Console.WriteLine("\nNum > 5  =  " + max5);

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > maxInArr)
                {
                    maxInArr = arr[i];
                    maxInArrPos = i;
                }
            }
            for (int i = maxInArrPos + 1; i < length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine("\nSum of Numb > max num - " + sum);
        }
    }
}

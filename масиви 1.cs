using System;

namespace масиви_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int sum = 0;
            Random ran = new Random();

            for (int i = 0; i < 100; i++)
            {
                array[i] = ran.Next(1, 25);
                sum += array[i];
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }

    }
}


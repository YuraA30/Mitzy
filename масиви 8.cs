using System;

namespace масиви_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.MinValue;
            int[,] b = new int[7, 5];
            Random random = new Random();
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    b[x, y] = random.Next(-50, 50);
                    Console.Write(b[x, y] + " " );
                    if (b[x, y] > k)
                    {
                        k = b[x, y];
                    }
                }
                Console.WriteLine("Число " + k);
                k = 0;
                Console.WriteLine();
            }
        }
    }
}
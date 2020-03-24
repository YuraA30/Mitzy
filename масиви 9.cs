using System;

namespace масив_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] b = new double[3, 8];
            int n = 0;
            Random random = new Random();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    b[x, y] = random.Next(10, 99);
                    if (b[x , y] % 2 == 0)
                    {
                        n++;
                    }
                    Console.Write(b[x, y] + " ");
                }
                Console.WriteLine(" ");
                
            }
            Console.WriteLine(n);
        } 
    }
}

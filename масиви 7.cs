using System;

namespace масиви_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] b = new int[5, 5];
            Random random = new Random();
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    b[x, y] = random.Next(2, 5);
                    if (x == y)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write(b[x, y] + "   ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}

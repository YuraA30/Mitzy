using System;

namespace цикли2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, a, k = 0; s = 0;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; a >= i; i++)
            {

                if (i % 2 == 0)
                {
                    k++;
                    s += i;
                }

            }
            Console.Write(s);
            Console.WriteLine();
            Console.Write(k);
        }
    }
}
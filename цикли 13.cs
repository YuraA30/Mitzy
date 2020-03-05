using System;

namespace цикли_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, k = 0;
            s = 0;
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                b = a % 10;
                s += b;
                a /= 10;
                k++;
            }
            Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine(s/k);
        }
    }
}

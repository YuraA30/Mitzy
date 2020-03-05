using System;

namespace цикли_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a == b && a == c && c == b)
            {
                Console.WriteLine("Числа рівні");
            }
            else {
                Console.WriteLine("Числа не рівні");
            }
            Console.WriteLine((a + b + c) / 3);
        }
    }
}

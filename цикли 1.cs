using System;

namespace цикли_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s; s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {

                s += i;

            }
            Console.Write(s);
        }
    }
}

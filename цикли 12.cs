using System;

namespace цикли_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 10 == 7)
            {
                Console.WriteLine("True");
            }
            else if (a / 10 == 7)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.Write("False");
            }
        }
    }
}

using System;

namespace цикли_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if ( x % y == 0)
            {
                Console.WriteLine(x / y);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

    }
}

using System;

namespace цикли_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a < 10 && b < 10 && b > 0 && a > 0)
            {
                Console.WriteLine(a*b);
            }
            else
            {
                Console.WriteLine("Error");
                
            } 
        }
    }
}

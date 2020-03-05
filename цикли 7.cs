using System;

namespace цикли7
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if ( a > b)
            {
                Console.WriteLine("1 число більше");
            }
            else 
            {
                Console.WriteLine("2 число більше");
            }
        }
    }
}

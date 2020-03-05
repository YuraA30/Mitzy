using System;

namespace ЦИКЛИ_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A більше за b");
            }
            else if (a == b)
            {
                Console.WriteLine("Вони рівні");
            }
            else
            {
                Console.WriteLine("В більше за а");
            }
        }
    }
}

using System;

namespace циклт_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, k, l, x , y;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            k = a % 10;
            l = (a / 10) + k;
            if ( l >= 10)
            {
                Console.WriteLine("Сума Двозначна");
            }
            else
            {
                Console.WriteLine("Сума not Двозначна");
            }
            x = b % 10;
            y = (b / 10) + k;
            if (y > l)
            {
                Console.WriteLine("2 число більше");
            }
            else if (y == l)
            {
                Console.WriteLine("вони рівні");
            }
            else
            {
                Console.WriteLine("1 число більше");
            }

        }
    }
}

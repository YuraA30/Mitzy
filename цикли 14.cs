using System;

namespace цикли_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b=0, c, d, k = 0;
            for(double i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    a += i; 
                }
                else if (i % 2 != 0)
                {
                    b += i;
                    k++;
                    if ( i !=33 )
                    Console.WriteLine("Квадрати = " + i * i);
                }

            }
            Console.WriteLine(a);
            Console.WriteLine(b / k);
        }
    }
}

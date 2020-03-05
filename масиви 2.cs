using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace масиви_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            int k = 0;
            double[] b = new double[20];
            for ( int i = 0; i < 20; i+=2)
            {
                Random ran = new Random();
                b[i] = ran.Next(-100, 100);
                Console.WriteLine("Наші числа" + b[i]);
                s += b[i];
                k++;
            }
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();
            Console.WriteLine(s/k);
        }

    }
}
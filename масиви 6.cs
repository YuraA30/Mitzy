using System;

namespace масив_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, x = 0;
            a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[50];
            Random ran = new Random();
            foreach (int i in b)
            {
                b[i] = ran.Next(-10, 10);
                Console.WriteLine("Значення масиву в масиві" + b[i]);
                x++;
                if (a == b[i])
                {
                    Console.WriteLine();
                    Console.WriteLine("ЄЄЄ число" + b[i]);
                    Console.WriteLine("Бойова позиція = " + x);

                }

            }
        }
    }
}

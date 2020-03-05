using System;

namespace масиви_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            int[] b = new int[50];
            Random ran = new Random();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = ran.Next(-50,50);
                Console.WriteLine("Значення масиву в масиві" + b[i]);

                if (b[i] > 0)
                {
                    s += b[i];
                }
            }
            Console.WriteLine(s);



        }
    }
}

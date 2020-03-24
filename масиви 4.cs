using System;

namespace масиви_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] b = new double[30];
            Random ran = new Random();
            int k = int.MinValue;
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = ran.Next(-150, 150);
                Console.WriteLine("Значення масиву в масиві" + b[i]);
                foreach(int c in b)
                {
                    if (c > k)
                    {
                        k = c;
                    }
                    
                }
                
                
            }
            Console.WriteLine();
            Console.WriteLine(k);
        }
    }
}

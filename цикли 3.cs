using System;

namespace цикли_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            double s = 0;
            m = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                s = s + s * 0.07;
            }
            Console.Write(s);
        }
    }
}

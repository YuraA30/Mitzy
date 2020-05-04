using System;

namespace методи_1
{




    public static class Matem 
    {
        public static void Information(int[] blocks, int k)
        {
            Console.WriteLine(blocks[k]);
        }
        public static int Max(int[] blocks)
        {
            int i = 0, n = 0;
            while (i < 10)
            {
                if (n < blocks[i])
                {
                    n = blocks[i];
                }
                i++;
            }
            return n;
        }
    }






    class matem
    {
        public void GetInformation(int[] block, int i)
        {
            Console.WriteLine(block[i]);
        }

        public int max(int[] block)
        {
            int i = 0, m = 0;
            while (i < 10)
            {
                if (m < block[i])
                {
                    m = block[i];
                }
                i++;
            }
            return m;
        }

        static public int dobutok(int[] block)
        {
            int i = 0, d = 1;
            while (i < 10)
            {
                d *= block[i];
                i++;
            }
            return d;
        }


        static public int suma(int[] block)
        {
            int i = 0, s = 1;
            while (i < 10)
            {
                s += block[i];
                i++;
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            int[] blo = new int[10];
            Random bbb = new Random();
            int i = 0;
            Console.WriteLine("Значення в масиві = ");
            while (i < 10)
            {
                blo[i] = bbb.Next(1, 10);
                matem output = new matem();
                output.GetInformation(blo, i);
                i++;
            }



            Console.WriteLine();
            matem m = new matem();
            Console.WriteLine("Max = " + m.max(blo));



            Console.WriteLine();
            Console.WriteLine("Введіть + щоб дізнатись суму, * щоб добуток");
            string k = Console.ReadLine();
            if (k == "*")
            {
                Console.Write(matem.dobutok(blo));
            }
            else if (k == "+")
            {
                Console.Write(matem.suma(blo));
            }
            else
            {
                Console.WriteLine("Ви нічого не хочете знати");
            }
            Console.WriteLine();



            Console.WriteLine("Значення в 2 масиві = ");
            Random rnd = new Random();
            int[] blo2 = new int[10];
            int z = 0;
            while (z < 10)
            {
                blo2[z] = rnd.Next(0, 15);
                Matem.Information(blo2, z);
                z++;
            }
            Console.WriteLine();


            Console.WriteLine("Mаксимальне значення з 2 масиву = " + Matem.Max(blo2));
        }
    }
}
using System;

namespace методи_2
{
    class Student1
    {
        public void step(int a)
        {
            Console.WriteLine("1 місяць" + a);
        }

        public void step(int a, int b)
        {
            Console.WriteLine("2 місяці" + (a+b));
        }

        public void step(int a, int b, int c)
        {
            Console.WriteLine("3 місяці" + (a+b+c));
        }

        public void step(int a, int b, int c, int d)
        {
            Console.WriteLine("4 місяці" + (a+b+c+d));
        }  

    }





    class student
    {
        public static float z;
        public string imia;
        public string nazvisko;
        public int age;
        public int kurs;


        public student(string imia, string nazvisko, int age, int kurs)
        {
            this.imia = imia;
            this.nazvisko = nazvisko;
            this.age = age;
            this.kurs = kurs;
        }

        public static void b()
        {
            z++;
        }

        static student()
        {
            Console.WriteLine();
            Console.WriteLine("Ураааааа статичний конструктор");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student[] Student = new student[5];
            Student[0] = new student("Kolia", "Lukaszenko", 19, 2);
            student.b();
            Student[1] = new student("Yarik", "Andruchov", 18, 1);
            student.b();
            Student[2] = new student("Yurii", "Bodnarenko", 31, 2);
            student.b();
            Student[3] = new student("Zahar", "Vylka", 19, 4);
            student.b();
            Student[4] = new student("Sasza", "Kurka", 21, 3);
            student.b();
            Console.WriteLine("Кількість обєктів = " + student.z);
            Console.WriteLine();



            Student1 KKK = new Student1();
            KKK.step(25);
            Student1 LLL = new Student1();
            LLL.step(25, 50);
            Student1 MMM = new Student1();
            MMM.step(25, 50 , 75);
            Student1 NNN = new Student1();
            NNN.step(25, 50 , 75 , 100);
        }
    }
}

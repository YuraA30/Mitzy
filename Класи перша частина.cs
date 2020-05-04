using System;

namespace класи_2
{
    class studiki
    {
        public string imia;
        public string nazvisko;
        public int age;
        public int kurs;
        public studiki()
        {
            imia = "Vasia";
            nazvisko = "Dubko";
            age = 19;
            kurs = 1;
        }
        public studiki(string imia, string nazvisko, int age, int kurs)
        {
            this.imia = imia;
            this.nazvisko = nazvisko;
            this.age = age;
            this.kurs = kurs;
        }
        public void GetInformation()
        {
            Console.WriteLine("Name : {0} \nNazvisko : {1} \nAge : {2} \nKurs : {3}\n", imia, nazvisko, age, kurs);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            studiki[] student = new studiki[10];
            student[0] = new studiki();
            student[1] = new studiki { imia = "Arsen", nazvisko = "Bandurak", age = 20, kurs = 2 };
            student[2] = new studiki { imia = "Vasia", nazvisko = "Kvas", age = 21, kurs = 3 };
            student[3] = new studiki { imia = "Kostia", nazvisko = "Lukinczuk", age = 22, kurs = 4 };
            student[4] = new studiki { imia = "Andrii", nazvisko = "Lys", age = 23, kurs = 5 };
            student[5] = new studiki("Kolia", "Lukaszenko", 19, 2);
            student[6] = new studiki("Yarik", "Andruchov", 18, 1);
            student[7] = new studiki("Yurii", "Bodnarenko", 31, 2);
            student[8] = new studiki("Zahar", "Vylka", 19, 4);
            student[9] = new studiki("Sasza", "Kurka", 21, 3);





            int k = 0;
                for (int a = 32; a >= 0; a--)
                {
                    for (; k <= 9; k++)
                    {
                        if (student[k].age == a)
                        {
                            student[k].GetInformation();
                        }
                    }
                    k = 0;
                }
            Console.WriteLine("___________________");
            Console.WriteLine("Age more than 20 : ");

            for (int i = 0; i < 10; i++)
            {
                if (student[i].age >= 20)
                {
                    student[i].GetInformation();
                }

            }

        }
    }
}


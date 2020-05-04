using System;

namespace класи_3
{
    class studiki
    {
        public string imia;
        public string nazvisko;
        public int age;
        public int kurs;
        public int ukr;
        public int eng;
        public int lit;
        public int zar;
        public studiki(string imia, string nazvisko, int age, int kurs, int ukr, int eng, int lit, int zar)
        {
            this.imia = imia;
            this.nazvisko = nazvisko;
            this.age = age;
            this.kurs = kurs;
            this.ukr = ukr;
            this.eng = eng;
            this.lit = lit;
            this.zar = zar;
        }
        public void GetInformation()
        {
            Console.WriteLine("Name : {0} \nNazvisko : {1} \nAge : {2} \nKurs : {3}\nUkrainian : {4}\nEnglish : {5}\nLiteratura : {6}\nZarubiszna : {7}\n", imia, nazvisko, age, kurs, ukr, eng, lit, zar);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            studiki[] student = new studiki[10];
            student[0] = new studiki("Vlad", "Didov", 20, 2, 3, 3, 3, 5);
            student[1] = new studiki("Arsen", "Bandurak", 20, 2, 5, 5, 5, 5);
            student[2] = new studiki("Vasia", "Kvas", 21, 3, 2, 3, 4, 5);
            student[3] = new studiki("Kostia", "Lukinczuk", 22, 4, 3, 3, 4, 5);
            student[4] = new studiki("Andrii", "Lys", 23, 5, 2, 3, 4, 5);
            student[5] = new studiki("Kolia", "Lukaszenko", 19, 2, 5, 5, 5, 5);
            student[6] = new studiki("Yarik", "Andruchov", 18, 1, 5, 3, 5, 5);
            student[7] = new studiki("Yurii", "Bodnarenko", 29, 2, 3, 3, 3, 3);
            student[8] = new studiki("Zahar", "Vylka", 19, 4, 2, 2, 2, 2);
            student[9] = new studiki("Sasza", "Kurka", 21, 3, 4, 5, 3, 2);

            Console.WriteLine("Наші двійошники : ");
            for (int i = 0; i <= 9; i++)
            {
                if (student[i].ukr == 2 || student[i].eng == 2 || student[i].lit == 2 || student[i].zar == 2)
                {
                    student[i].GetInformation();
                }
            }
            Console.WriteLine("___________________");
            Console.WriteLine("Ті хто має усе 5 спереді а хто гірше ідуть на спад до середньої оцінки 2: ");
            int k = 0;
            for (int a = 20; a >= 0; a--)
            {
                for (; k <= 9; k++)
                {
                    if (student[k].ukr + student[k].eng + student[k].lit + student[k].zar == a)
                    {
                        student[k].GetInformation();
                    }
                }
                k = 0;


            }

        }
    }
}

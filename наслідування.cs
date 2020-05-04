using System;

namespace наслідування
{

    class Human
    {
        private string nazvisko;
        private string imia;
        private int age;

        public string Nazvisko
        {
            get
            {
                return nazvisko;
            }
            set
            {
                nazvisko = value;
            }
        }

        public string Imia
        {
            get
            {
                return imia;
            }
            set
            {
                imia = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Human(string Nazvisko, string Imia, int Age)
        {
            this.nazvisko = Nazvisko;
            this.imia = Imia;
            this.age = Age;
        }

        public void GetInformation()
        {
            Console.WriteLine("Прізвище, імя і вік : {0}, {1}, {2}.", Nazvisko, Imia, Age);
            Console.WriteLine();
        }
    }

    class Student : Human
    {
        private string kurs;
        private int kurokiv;

        public Student(string nazvisko, string imia, int age, string kurs, int kurokiv) : base(nazvisko, imia, age)
        {
            this.kurs = kurs;
            this.kurokiv = kurokiv;
        }

        public void Information()
        {
            Console.WriteLine("Прізвище, імя, вік, прослуханий курс, кількість занять : {0}, {1}, {2}, {3}, {4}.", Nazvisko, Imia, Age, kurs, kurokiv);
            Console.WriteLine();
        }
    }

    class Teacher : Human
    {
        private string course1;
        private string course2;


        public Teacher(string surname, string name, int age, string course1, string course2) : base(surname, name, age)
        {
            this.course1 = course1;
            this.course2 = course2;
        }
        public void GetInfo()
        {
            Console.WriteLine("Прізвище, імя, вік, 1 курс, 2 курс: {0}, {1}, {2}, {3}, {4}. ", Nazvisko, Imia, Age, course1, course2);
            Console.WriteLine();
        }

    }

    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////


    abstract class Kurs 
    {
        private string namekurs;
        private int kpar;
        private int ksluchacziv;


        public string Namekurs
        {
            get
            {
                return namekurs;
            }
            set
            {
                namekurs = value;
            }
        }
        public int Kpar
        {
            get
            {
                return kpar;
            }
            set
            {
                kpar = value;
            }
        }
        public int Ksluchacziv
        {
            get
            {
                return ksluchacziv;
            }
            set
            {
                ksluchacziv = value;
            }
        }

        public abstract void GetInformation1();
    }

    class OngoingKurs : Kurs
    {
        private string EndOfKurs;
        public OngoingKurs(string namekurs, int kpar, int ksluchacziv, string EndOfKurs)
        {
            this.Namekurs = namekurs;
            this.Kpar = kpar;
            this.Ksluchacziv = ksluchacziv;
            this.EndOfKurs = EndOfKurs;
        }
        public override void GetInformation1()
        {
            Console.WriteLine("Назва курсу : {0} || К-сть занять: {1} || К-сть студентів : {2} || Дата завершення : {3}.", Namekurs, Kpar, Ksluchacziv, EndOfKurs);
            Console.WriteLine();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Human A = new Human("Луджак", "Василь", 11);
            A.GetInformation();

            Student B = new Student("Балагурак", "Іван", 18, "Історія", 31);
            B.Information();

            Teacher C = new Teacher("Джимагаль", "Володимир", 34, "Хімія", "Фізика");
            C.GetInfo();

            ////////
            ///
            // Kurs D = new Kurs("Z144", 180, 19); в абстракнорму класі так не паше

            OngoingKurs E = new OngoingKurs("Z144", 180, 19, "я не знаю");
            E.GetInformation1();
        }

    }
}


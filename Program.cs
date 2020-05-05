using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace поліморфізм
{

    abstract class Animals
    {
		private string sobriquet;
		private string type;
		private double size;
		private string color;
		private int age;
		private int paws;
		private string tail;

		public string Sobriquet
		{
			get { return sobriquet; }
			set { sobriquet = value; }
		}

		public string Type
		{
			get { return type; }
			set { type = value; }
		}
		public double Size
		{
			get { return size; }
			set { size = value; }
		}
		public string Color
		{
			get { return color; }
			set { color = value; }
		}
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public int Paws
		{
			get { return paws; }
			set { paws = value; }
		}
		public string Tail
		{
			get { return tail; }
			set { tail = value; }
		}



		public Animals(string Sobriquet, string Type, double Size, string Color, int Age, int Paws, string Tail)
		{
			this.sobriquet = Sobriquet;
			this.type = Type;
			this.size = Size;
			this.color = Color;
			this.age = Age;
			this.paws = Paws;
			this.tail = Tail;
		}


        public abstract void GetInformation();
        public abstract void Sound();
    }

    /// <summary>
    /// ////////////////////////////////////
    /// </summary>
    interface Irun
    {
        void Run();
    }
    interface Iignor
    {
        void Ignor();
    }
    interface Iagresia
    {
        void Agresion();
    }


    /// <summary>
    /// //////////////////////////////////
    /// </summary>
    class cat : Animals, Irun, Iignor
    {
        private string breed;
        private string LengthOfWool;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string lengthOfWool
        {
            get { return LengthOfWool; }
            set { LengthOfWool = value; }
        }

        public cat(string sobriquet, string type, double size, string color, int age, int paws, string tail, string Breed, string lengthOfWool) : base(sobriquet, type, size, color, age, paws, tail)
        {
            this.breed = Breed;
            this.LengthOfWool = lengthOfWool;
        }
        public override void GetInformation()
        {
            Console.WriteLine("Котяра Кличка {0}, тип {1}, розмір {2}, колір {3}, вік {4}, к-сть лап {5}, наявність хвоста {6}, порода {7}, ромір шерсті {8}", Sobriquet, Type, Size, Color, Age, Paws, Tail, Breed, lengthOfWool);
            Console.WriteLine();
        }
        public override void Sound()
        {
            Console.WriteLine("Мяу\n");
        }
        public void Run()
        {
            Console.WriteLine("Кіт тікає\n");
        }
        public void Ignor()
        {
            Console.WriteLine("Коту всерівно\n");
        }
    }

    /// <summary>
    /// /////////////////////////////////////////////
    /// </summary>

    class dog : Animals,  Iignor, Iagresia
    {
        private string breed;
        private string appointment;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string Appointment
        {
            get { return appointment; }
            set { appointment = value; }
        }

        public dog(string sobriquet, string type, double size, string color, int age, int paws, string tail, string Breed, string Appointment) : base(sobriquet, type, size, color, age, paws, tail)
        {
            this.breed = Breed;
            this.appointment = Appointment;
        }
        public override void GetInformation()
        {
            Console.WriteLine("Кличка {0}, тип {1}, розмір {2}, колір {3}, вік {4}, к-сть лап {5}, наявність хвоста {6}, порода {7}, призначення {8}", Sobriquet, Type, Size, Color, Age, Paws, Tail, Breed, Appointment);
            Console.WriteLine();
        }
        public override void Sound()
        {
            Console.WriteLine("Гав\n");
        }
        public void Agresion()
        {
            Console.WriteLine("Хоче кусать\n");
        }
        public void Ignor()
        {
            Console.WriteLine("Собаці на вас всерівно\n");
        }
    }
    
    /// <summary>
    /// //////////////////////////////////////////
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            cat AAA = new cat("Мойша", "Не наю", 18.7, "Чорний", 2, 4, "Є хвіст", "Пухнастий", "Середня");
            AAA.GetInformation();
            AAA.Sound();
            AAA.Run();
            AAA.Ignor();

            dog BBB = new dog("Друг Мойші", "Ну на дворі бігає", 30.7, "Сіро-чорний", 5, 4, "Є хвіст", "Підбуль", "Щоб кусать");
            BBB.GetInformation();
            BBB.Sound();
            BBB.Agresion();
            BBB.Ignor();
        }
    }
}

using System;

namespace Test
{
    public class Bird : IFlyable
    {
        public string Name;
        public bool CanFly;

        public Bird()
        {
        }

        public Bird(string name, bool canFly)
        {
            Name = name;
            CanFly = canFly;
        }

        public void Input()
        {
            Name = Console.ReadLine();
            CanFly = Convert.ToBoolean(Console.ReadLine());
        }


        void IFlyable.Fly()
        {
            if (CanFly == true)
            {
                Console.WriteLine($"The {Name} bird is able to fly");
            }
            else
            {
                Console.WriteLine($"The {Name} bird can't fly");
            }
        }
    }

    class Plane : IFlyable
    {
        public string Mark;
        public int HighFly;

        public Plane()
        {
        }

        public Plane(string mark, int highFly)
        {
            Mark = mark;
            HighFly = highFly;
        }

        public void Input()
        {
            Mark = Console.ReadLine();
            HighFly = Convert.ToInt32(Console.ReadLine());
        }


        void IFlyable.Fly()
        {
            if (HighFly > 0)
            {
                Console.WriteLine($"The {Mark} plane flies");
            }
            else
            {
                Console.WriteLine($"The {Mark} plane doesn't fly");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please, enter the Bird1 data: name; ability to fly (true or false value)");
            IFlyable bird1 = new Bird();
            bird1.Input();

            Console.WriteLine("Please, enter the Bird1 data: name; ability to fly (true or false value)");
            IFlyable bird2 = new Bird();
            bird2.Input();

            Console.WriteLine("Please, enter the Plane1 data: name; flight altitude (meters)");
            IFlyable plane1 = new Plane();
            plane1.Input();

            Console.WriteLine("Please, enter the Plane2 data: name; flight altitude (meters)");
            IFlyable plane2 = new Plane();
            plane2.Input();

            bird1.Fly();
            bird2.Fly();
            plane1.Fly();
            plane2.Fly();

            Console.ReadLine();
        }
    }
}
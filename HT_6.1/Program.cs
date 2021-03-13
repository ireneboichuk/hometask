using System;
using System.Collections.Generic;

namespace Test
{
    public class Bird : IFlyable
    {
        public string Name { get; set; }
        public bool CanFly { get; set; }

        void IFlyable.Fly(bool a)
        {
            CanFly = a;
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
        public bool HighFly;

        void IFlyable.Fly(bool b)
        {
            HighFly = b;
            if (HighFly == true)
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
            List<IFlyable> objects = new List<IFlyable>(4);
            objects.Add(new Bird() { Name = "Owl" });
            objects.Add(new Bird() { Name = "Penquin" });
            objects.Add(new Plane() { Mark = "Boeing"});
            objects.Add(new Plane() { Mark = "Aerobus" });

            objects[0].Fly(true);
            objects[1].Fly(false);
            objects[2].Fly(true);
            objects[3].Fly(true);

            Console.ReadLine();
        }
    }
}
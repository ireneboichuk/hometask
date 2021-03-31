using System;
namespace Test
{
    public class Person
    { 
        private string name;
        public string Name { get => name; }

        public Person(string name)
        {
            this.name = name; 
        }

        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }
}
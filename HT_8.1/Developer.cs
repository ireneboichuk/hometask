using System;
namespace Test
{
    public class Developer : Staff
    {
        private string level;

        public Developer(string name, string level) : base(name)
        {
            this.level = level;
        }

        public override void Print()
        {
            Console.WriteLine("Person {0} has level: {1}", Name, this.level);
        }
    }
}
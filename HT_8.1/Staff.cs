using System;
namespace Test
{
    public class Staff : Person
    {
        private int salary;

        public Staff(string name) : base(name)
        {
        }

        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }
    
        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1}", Name, this.salary);
        }
    }
}
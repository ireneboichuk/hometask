using System;
namespace Test
{
    public class Teacher : Staff
    {
        private string subject;
        
        public Teacher(string name, string subject) : base(name)
        {
            this.subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine("Person {0} teaches subject: ${1}", Name, this.subject);
        }
    }
}
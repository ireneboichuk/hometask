using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter Person1 data: name, date of birth (dd/MM/yyyy)");
            Person person1 = new Person();
            person1.Input();

            Console.WriteLine("Please, enter Person2 data: name, date of birth (dd/MM/yyyy)");
            Person person2 = new Person();
            person2.Input();

            Console.WriteLine("Please, enter Person2 data: name, date of birth (dd/MM/yyyy)");
            Person person3 = new Person();
            person3.Input();

            Console.WriteLine("Please, enter Person4 data: name, date of birth (dd/MM/yyyy)");
            Person person4 = new Person();
            person4.Input();

            Console.WriteLine("Please, enter Person5 data: name, date of birth (dd/MM/yyyy)");
            Person person5 = new Person();
            person5.Input();

            Console.WriteLine("Please, enter Person6 data: name, date of birth (dd/MM/yyyy)");
            Person person6 = new Person();
            person6.Input();

            person1.Output();
            person2.Output();
            person3.Output();
            person4.Output();
            person5.Output();
            person6.Output();

            person1.ChangeName();
            person2.ChangeName();
            person3.ChangeName();
            person4.ChangeName();
            person5.ChangeName();
            person6.ChangeName();

            person1.Output();
            person2.Output();
            person3.Output();
            person4.Output();
            person5.Output();
            person6.Output();

            List<string> names = new List<string>() { };
            names.Add(person1.Name);
            names.Add(person2.Name);
            names.Add(person3.Name);
            names.Add(person4.Name);
            names.Add(person5.Name);
            names.Add(person6.Name);

            List<string> equalNames = new List<string>() { };

            foreach (var n in names.GroupBy(n => n).Select(n => n.ToList()))
            {
                int index = 1;
                foreach (var item in n)
                {
                    equalNames.Add(string.Format("{0}[{1}]", item, index++));
                }
            }

            Console.WriteLine($"The Following Persons have the same names:");
            foreach (string name in equalNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

        }
    }
}
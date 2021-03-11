using System;

namespace Test
{
    public class Person
    {
            public string Name { get; private set; }
            public DateTime BirthYear { get; private set; }

            public Person() { }

            public Person(string name, DateTime year)
            {
                Name = name;
                BirthYear = year;
            }

            public int Age(DateTime birthYear)
            {
                var today = DateTime.Today;
                int personAge = today.Year - birthYear.Year;
                return personAge;
            }

            public void Input()
            {
                Name = Console.ReadLine();
                string dateInput = Console.ReadLine();
                BirthYear = DateTime.ParseExact(dateInput, "dd/MM/yyyy", null);
            }

            public void Output() => ToString();

            public override string ToString()
            {
                var personAge = this.Age(this.BirthYear);
                Console.WriteLine($"Name value is: {Name} and Age value is: {personAge}");
                return null;
            }

            public void ChangeName()
            {
                int personAge = this.Age(this.BirthYear);
                if (personAge < 16)
                {
                    Name = "Too Young";
                }
            }

            public static bool operator ==(Person person1, Person person2)
            {
                return ((person1.Name == person2.Name));
            }

            public static bool operator !=(Person person1, Person person2)
            {
                return ((person1.Name != person2.Name));
            }

            public static bool StringComparer(string name1, string name2)
            {

                if (name1 == name2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
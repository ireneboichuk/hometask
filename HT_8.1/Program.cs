using System;
using System.Collections.Generic;

/* 
8.1
1) Додайте два класи Person та Staff 
2) Утворіть два класи Teacher та  Developer, похідні від Staff. 
Для класу Teaсher додайте поле subject, а для класу Developer – поле level, перевизначте метод Print для обох класів.
3)В Main  визначте список типу Person та додайте до нього об’єкти кожного типу. Викличте для кожного елементу списку метод Print()
4) Введіть ім’я персони і знайдіть чи є така персона у вашому списку, якщо так – видрукуйте про неї інформацію
*/

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Anna"));
            people.Add(new Staff("John", 2000));
            people.Add(new Teacher("Lisa", "Math"));
            people.Add(new Developer("Mattew", "senior"));

            foreach (var p in people)
                p.Print();

            Console.WriteLine("Введіть ім'я персони: ");
            string personName = Console.ReadLine();
            string a;

            foreach (var p in people)
            {
                if (p.Name == personName)
                {
                    p.Print();
                }
            }

            Console.ReadLine();
        }
    }
}
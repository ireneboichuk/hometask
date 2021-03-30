using System;
using System.Collections.Generic;

/*
6.4.
Create Console Application project in VS. In the Main() method declare Dictionary<uint,string>. 
Add to Dictionary from Console seven pairs (ID, Name) of some persons. Ask user to enter ID, 
then find and write corresponding Name from your Dictionary. If you can't find this ID - say about it to user. 
*/

namespace Test
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> openWith = new Dictionary<uint, string>(); ;
            openWith.Add(1, "Anna");
            openWith.Add(3, "John");
            openWith.Add(2, "Sofia");
            openWith.Add(4, "Lisa");
            openWith.Add(5, "Irene");
            openWith.Add(6, "Megan");
            openWith.Add(7, "Kate");

            Console.WriteLine("Введіть значення ID персони: ");
            uint idValue = Convert.ToUInt32(Console.ReadLine());

            string value = "";
            if (openWith.TryGetValue(idValue, out value))
            {
                Console.WriteLine("For key = {0}, value = {1}.", idValue, value);
            }
            else
            {
                Console.WriteLine("Key = {0} is not found.", idValue);
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

/*
6.2.
Declare myColl of 10 integers and fill it from Console.
	1) Find and print all positions of element -10 in the collection
	2) Remove from collection elements, which are greater then 20.  
       Print collection
	3) Insert elements 1,-3,-4 in positions 2, 8, 5. Print collection
	4) Sort and print collection 
 Use next Collections for this tasks: List and ArrayList
*/

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Введіть 10 цілих чисел");
            for (int n = 0; n < 11; n++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            List<int> indexList = new List<int>();
            int i = 0;
            while (i < list.Count)
            {
                if (list[i] == -10)
                {
                    indexList.Add(i);
                }
                i++;
            }

            Console.WriteLine("Всі позиції елементів -10 в колекції");
            foreach (var index in indexList)
            {
                Console.WriteLine(index);
            }

            // Видалення елементів з колекції, котрі більші, ніж 20
            Console.WriteLine("Видалення елементів з колекції, котрі більші, ніж 20");

            for (int a = list.Count - 1; a >= 0; a--)
            {
                if (list[a] > 20)
                {
                    list.Remove(list[a]);
                }
            }

            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            // Insert elements 1,-3,-4 in positions 2, 8, 5. Print collection
            Console.WriteLine("Додати елементи 1,-3,-4 на позиції 2, 8, 5");
            list.Insert(2, 1);
            list.Insert(8, -3);
            list.Insert(5, -4);

            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            // Сортування колекції
            Console.WriteLine("Сортування колекції");
            list.Sort();

            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }


            Console.ReadLine();
        }
    }
}
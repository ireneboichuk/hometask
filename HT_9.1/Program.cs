using System;
using System.Collections.Generic;
using System.Linq;

/* 9.1
1) Утворити і заповнити колекцію з 10 цілих чисел
2) Отримати і вивести на консоль тільки від’ємні числа
3) Отримати і вивести на консоль тільки додатні парні числа
4) Отримати найбільший та найменший елементи з масиву, а також суму всіх елементів.
5) Отримати перший елемент з масиву, який є менший ніж середнє арифметичне значення елементів масиву
6) Посортувати масив з використанням OrderBy
*/

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> numbers = new List<double>();

            Console.WriteLine("Введіть 10 цілих чисел (додатні і від'ємні) ");
            for (int n = 0; n < 11; n++)
            {
                numbers.Add(Convert.ToDouble(Console.ReadLine()));
            }

            // Отримання і виведення на консоль від'ємних чисел
            var negativeNumbers = from n in numbers
                                  where n < 0
                                  select n;

            Console.WriteLine("Список від'ємних чисел: ");
            foreach (double s in negativeNumbers)
            {
                Console.WriteLine(s);
            }

            // Отримання і виведення на консоль додатніх чисел
            var positiveNumbers = numbers.Where(n => n > 0);

            Console.WriteLine("Список додатніх чисел: ");
            foreach (double s in positiveNumbers)
            {
                Console.WriteLine(s);
            }

            // Отримання і виведення на консоль додатніх парних чисел
            var positiveEvenNumbers = from n in numbers
                                      where n > 0 && n % 2 == 0
                                      select n;

            Console.WriteLine("Список додатніх парних чисел: ");
            foreach (double s in positiveEvenNumbers)
            {
                Console.WriteLine(s); 
            }

            // Отримання і виведення на консоль найбільшого і найменшого чисел, суми всіх чисел
            Console.WriteLine($"Найбільше число: {numbers.Max()}");
            Console.WriteLine($"Найменше число: {numbers.Min()}");
            Console.WriteLine($"Сума всіх елементів: {numbers.Sum()}");


            // Отримання першого елементу масиву, який є менший ніж середнє арифметичне значення елементів масиву
            double average = numbers.Average();
            var lessThanAverage = numbers.Where(n => n < average);
            Console.WriteLine($"Перший елемент масиву, який є менший ніж середнє арифметичне значення елементів масиву: {lessThanAverage.ElementAt(0)}");


            // Сортування масиву
            Console.WriteLine("Посортований масив:");

            var sortedList = numbers.OrderBy(n => n);

            foreach (double s in sortedList)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
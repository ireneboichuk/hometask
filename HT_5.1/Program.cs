using System;
using System.Linq;

/* 
5.1 
Визначити клас Car з полями назва, колір, ціна, const полем CompanyName 
Створити два конструктори – дефолтний і з параметрами.
Створити властивість доступу до поля колір. 
Визначити методи Input() –  для введення даних про машину з консолі,
                               Print() - для виведення даних про машину на консоль
                               ChangePrice(double x) – для зміни ціни на х%
Ввести дані про 3 авто. 
Зменшити їх ціну на 10%, вивести дані про авто.
Ввести новий колір і пофарбувати авто з кольором white у вказаний колір
Перевантажити оператор == для класу Car, авто рівні, якщо назва та ціна рівні 
Перевизначити в класі Car метод ToString(), який повертає рядок з даними про авто
*/

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter car1 data: name, color, price");
            Car car1 = new Car();
            car1.Input();

            Console.WriteLine("Please, enter car2 data: name, color, price");
            Car car2 = new Car();
            car2.Input();

            Console.WriteLine("Please, enter car3 data: name, color, price");
            Car car3 = new Car();
            car3.Input();

            car1.ChangePrice(10);
            car2.ChangePrice(10);
            car3.ChangePrice(10);

            car1.Print();
            car2.Print();
            car3.Print();

            Console.WriteLine("Please, enter a new color");
            string newColor = Console.ReadLine();

            car1.ChangeColor(newColor);
            car2.ChangeColor(newColor);
            car3.ChangeColor(newColor);

            if (((car1.Name == car2.Name) && (car1.Name == car3.Name)) && ((car1.Price == car2.Price) && (car1.Price == car3.Price)))
            {
                Console.WriteLine("The following cars can be considered equal");
                car1.Print();
                car2.Print();
                car3.Print();
            }
            else if ((car2.Name == car3.Name) && (car2.Price == car3.Price))
            {
                Console.WriteLine("The following cars can be considered equal");
                car2.Print();
                car3.Print();
            }
            else if ((car1.Name == car3.Name) && (car1.Price == car3.Price))
            {
                Console.WriteLine("The following cars can be considered equal");
                car1.Print();
                car3.Print();
            }
            else if ((car1.Name == car2.Name) && (car1.Price == car2.Price))
            {
                Console.WriteLine("The following cars can be considered equal");
                car1.Print();
                car2.Print();
            }
            else
            {
                Console.WriteLine("There are no equal cars in the list");
            }

            car1.ToString();
            car2.ToString();
            car3.ToString();

            Console.ReadLine(); 
        }
    }
}


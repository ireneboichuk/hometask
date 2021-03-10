using System;
namespace Test1.TestFolder
{
    public class Car
    {
        const string companyName = "MyCompany";

        public double Price { get; private set; }
        public string Name { get; private set; }
        public string Сolor { get; private set; }

        public Car() { }

        public void ToString() { }

        public Car(string name, string color, double price)
        {
            Name = name;
            Сolor = color;
            Price = price;
        }

        public void Input()
        {
            Name = Console.ReadLine();
            Сolor = Console.ReadLine();
            Price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Car {0} with color {1} and with {2}$", Name, Сolor, Price);
        }

        public void ChangePrice(double x)
        {
            x = x / 100;
            Price = Price - (Price * x);
        }

        public void ChangeColor(string newColor)
        {
            if (Сolor == "white")
            {
                Сolor = newColor;
                Console.WriteLine("Car {0} with color {1} and with {2}$", Name, Сolor, Price);
            }
            else
            {
                Console.WriteLine("Car {0} with color {1} and with {2}$", Name, Сolor, Price);
            }
        }

        public static bool operator ==(Car car1, Car car2)
        {
            return ((car1.Name == car2.Name) && (car1.Price == car2.Price));
        }
         
        public static bool operator !=(Car car1, Car car2)
        {
            return ((car1.Name != car2.Name) && (car1.Price != car2.Price));
        }

        public string ToString(Car car)
        {
            return "Car " + Name + " with color " + Сolor + " and with " + Price + " $"; 
        }
    }
}
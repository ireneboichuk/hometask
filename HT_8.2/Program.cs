using System;
using System.Collections.Generic; 

/* 8.1
1) Create abstract class Shape with field name and property Name. 
   Add constructor with 1 parameter and abstract methods Area() and Perimeter(), which can return area and perimeter of shape; 
2) Create classes Circle, Square derived from Shape with field radius (for Circle) and side (for Square).
   Add necessary constructors, properties to these classes, override methods from abstract class Shape.
   a) In Main() create list of Shape, then ask user to enter data of 10 different shapes.  Write name, area and perimeter of all shapes. 
   b) Find shape with the largest perimeter and print its name. 
3) Sort shapes by area and print obtained list (Remember about IComparable)
*/

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> shapes = new List<double>();
            List<Circle> circles = new List<Circle>();
            List<Square> squares = new List<Square>();

            Console.WriteLine("Введіть 10 значень, які будуть використані для радіуса та сторони квадрата: ");
            for (int n = 0; n < 11; n++)
            {
                shapes.Add(Convert.ToDouble(Console.ReadLine()));
            }

            for (int n = 0; n < 11; n++)
            {
                circles.Add(new Circle() { Radius = shapes[n] });
                squares.Add(new Square() { Side = shapes[n] });
            }


            foreach (Circle p in circles)
            {
                Console.WriteLine($"Для кола з радіусом: {p.Radius}, значення площі дорівнює: {p.Area(p.Radius)} " +
                    $"значення периметру дорівнює: {p.Perimeter(p.Radius)}"
                    );
            }

            Console.WriteLine("-------------");

            foreach (Square p in squares)
            {
                Console.WriteLine($"Для квадрата з стороною: {p.Side}, значення площі дорівнює: {p.Area(p.Side)} " +
                    $"значення периметру дорівнює: {p.Perimeter(p.Side)} "
                    );
            }

            Console.ReadLine();
        }
    }
}
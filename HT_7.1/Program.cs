using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type two double numbers: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            try
            {
                double result1 = Div(a, b);
                Console.WriteLine(result1);
            }
            catch (DivideByZeroException) when (b == 0)
            {
                Console.WriteLine("Action failed! DivideByZeroException");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Action failed! ArgumentException");
            }
            catch (FormatException)
            {
                Console.WriteLine("Action failed! FormatException");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"Action failed! {e.Message}");
            }
            finally
            {
                Console.WriteLine(
                  "The finally block");
            }

            Console.ReadLine();
        }

        static double Div(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}
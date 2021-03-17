using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type two double numbers: ");

            try
            {
                decimal a = Convert.ToDecimal(Console.ReadLine());
                decimal b = Convert.ToDecimal(Console.ReadLine());

                decimal result1 = Div(a, b);
                Console.WriteLine(result1);
            }
            catch (DivideByZeroException)
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

        static decimal Div(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber / secondNumber;
            return result;
        }
    }
}
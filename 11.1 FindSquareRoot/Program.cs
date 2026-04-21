using System;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
namespace FindSquareRoot
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number to output a square root! >> ");
            double squareRoot = 0;
            double input = 0;
            try
            {
                double userInput = Convert.ToDouble(Console.ReadLine());
                double answer = Math.Sqrt(userInput);
                if (double.IsNegative(answer))
                {
                    throw new NegativeException();
                }
                else
                {
                    squareRoot += answer;
                    input += userInput;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("\nNot a number");
                System.Environment.Exit(0);
            }
            catch (NegativeException)
            {
                
            }
            finally
            {
                Console.WriteLine($"/sqrt{input} = {squareRoot}");
            }
            
        }
    }
    internal class NegativeException : Exception
    {
        public NegativeException()
        {
            Console.WriteLine("\nNumber cannot be negative");
            System.Environment.Exit(0);
        }
    }
}

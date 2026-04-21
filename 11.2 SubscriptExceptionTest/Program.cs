using System;
namespace SubscriptExceptionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 5.5;
            double[] array = new double[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
                value++;
            }
            try
            {
                Console.WriteLine("The arrays length is 10. Input the section\nof the array you want to see from 1-10");
                Console.Write(">> ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Value is : {array[userInput - 1]}");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine("The arrays length is 10!\n your input is too strong!!");
            }
        }
    }
}

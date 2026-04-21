using System;
namespace ConvertMilesToKilometers
{
    internal class Program
    {
        static double ConvertMileToKilo(double miles)
        {
            return miles * 1.60934;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter miles to covert >> ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{miles} miles converts to {ConvertMileToKilo(miles)} kilometers");
        }
    }
}

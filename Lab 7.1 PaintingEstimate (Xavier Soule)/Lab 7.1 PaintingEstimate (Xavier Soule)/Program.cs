using System;
namespace PaintingEstimate
{
    internal class Program
    {
        //how did i not understand this the first time
        private static double ComputePrice(double wallFt)
        {
            double wallArea = ((wallFt * 9) * 4);
            double price = wallArea * 6;
            return price;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter length of wall in Ft. >> ");
            int.TryParse(Console.ReadLine(), out int value);
            double wall = value;
            Console.WriteLine($"Total price is {ComputePrice(wall).ToString("C")}");
        }
    }
}

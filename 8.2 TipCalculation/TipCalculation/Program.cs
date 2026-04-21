using System;
namespace TipCalculation
{
    internal class TipCalculation
    {
        static void Main(string[] args)
        {
            TipCalc(30.00, 0.20);
            TipCalc(40.00, 20);
            TipCalc(199.99, 0.30);
            TipCalc(80.85, 10);
        }
        private static void TipCalc(double price, double tipPercent)
        {
            double tipValue = price * tipPercent;
            double totalPrice = price + tipValue;
            Console.WriteLine($"Meal total is {totalPrice:C}.\nMeal price is {price:C}.\nTip percent is {tipPercent:P1}.\nTip value is {tipValue:C}\n");
            Console.WriteLine("^ This is using Method 1, double price and double tipPercent!\n");
        }
        private static void TipCalc(double price, int tipDollars)
        {           
            double totalPrice = price + tipDollars;
            double tipPercent = (tipDollars / totalPrice);
            Console.WriteLine($"Meal total is {totalPrice:C}.\nMeal price is {price:C}.\nTip percent is {tipPercent:P}.\nTip value is {tipDollars:C}\n");
            Console.WriteLine("^ This is using Method 2, double price and int tipDollars!\n");
        }

    }
}

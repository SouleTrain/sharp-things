using System;
namespace IntegerFacts
{
    internal class IntegerFacts
    {
        private static int FillArray(int[] Array)
        {
            int count = 0;
            Console.Write("Enter 10 numbers to fill into a list\n");
            while (count < Array.Length)
            {
                Console.Write(">> ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    Array[count++] = value;
                }
                else
                {
                    Console.WriteLine("not a integer");
                }
                    
            }
            return count;
        }
        private static void Stats(int[] Array, int count, out int high, out int low, out int sum, out int avg)
        {
            high = Array[0];
            low = Array[0];
            sum = 0;
            for (int i = 0; i < count; i++)
            {
                if (Array[i] > high)
                {
                    high = Array[i];
                }
                if (Array[i] < low)
                {
                    low = Array[i];
                }
                sum += Array[i];
            }
            avg = sum / count;
        }
        static void Main(string[] args)
        {
            int[] intList = new int[10];
            int highNumber, lowNumber, sum, avg;
            int count = FillArray(intList);
            Stats(intList, count, out highNumber, out lowNumber, out sum, out avg);
            Console.WriteLine($"Items are:\n");
            Console.WriteLine($"high is {highNumber}, low is {lowNumber}, sum is {sum}, average is {avg}");
        }
    }
}


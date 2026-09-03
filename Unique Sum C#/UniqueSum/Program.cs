using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;

internal class UniqueSum()
{
    static void Main()
    {
        double[] testArray = [1 ,2 ,2 ,3, 4];
        double[] testArray2 = [10.2, 1.1, 5, 6, 1.1, 12.3];

        UniqueSum.Solve(testArray);
        UniqueSum.Solve(testArray2);

        UniqueSum.SolveDistinct(testArray);
        UniqueSum.SolveDistinct(testArray2);
    }

    static void Solve(double[] input)
    {
        double answer = 0;
        List<double> uniqeNumbers = [];
        Array.Sort(input);

        if (input.Length > 0)
        {
            uniqeNumbers.Add(input[0]);
        }

        for (int i = 1; i < input.Length; i++)
        {
           
            if (input[i] != input[i - 1])
            {
                uniqeNumbers.Add(input[i]);
            }
        }

        Console.WriteLine("--Original Array--\n");
        foreach (double num in input)
            Console.Write($"{num}, ");


        Console.WriteLine("\n\n--New Array--\n");
        foreach (double num in uniqeNumbers)
        {
            System.Console.Write($"{num}  ");
            answer += num;
        }
        Console.WriteLine($"\n\nSum of unique numbers: {Convert.ToDecimal(answer)}\n\n");
        Console.WriteLine("----------^^ This used my own written approach! ^^----------\n\n");
    }

    static void SolveDistinct(double[] input)
    {
        double answer = 0;
        Array.Sort(input);
        IEnumerable<double> uniqueNumbers = input.Distinct();

        Console.WriteLine("--Original Array--\n");
        foreach (double num in input)
        {
            Console.Write($"{num}  ");
        }

        Console.WriteLine("\n\n--New Array--\n");
        foreach (double num in uniqueNumbers)
        {
            Console.Write($"{num}  ");
            answer += num;
        }

        Console.WriteLine($"\n\nSum of unique numbers : {Convert.ToDecimal(answer)}");
        Console.WriteLine("\n\n----------^^ This used Linqs .ToDinstinct built in approach! ^^----------\n\n");


    }

}
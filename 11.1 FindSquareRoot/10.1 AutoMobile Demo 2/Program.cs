using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.ExceptionServices;

namespace AutoMobile_Demo_2
{
    internal class Program
    {
        static void Main()
        {
            //did not know you could make sized arrays with objects thats cool
            AutoMobile[] cars = new AutoMobile[8];
            int[] id = new int[8];

            int year;
            int price;
            int idnum;
            bool isUniqueID;
            //forgot to set size to 8 in last submit
            for (int i = 0; i < 8; i++)
            {
                isUniqueID = false;
                Console.Write("Enter make: >> ");
                string make = Console.ReadLine();

                //infite loop until acceptable data for all loops
                while (true)
                {
                    Console.Write("Enter year: >> ");
                    if (int.TryParse(Console.ReadLine(), out year))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input");
                }
                while (true)
                {
                    Console.Write("Enter price: >> ");
                    if (int.TryParse(Console.ReadLine(), out price))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input");
                }
                while (!isUniqueID)
                {
                    Console.Write("Enter ID number: >> ");
                    if (int.TryParse(Console.ReadLine(), out idnum))
                    {
                        bool duplicate = false;
                        foreach (int num in id)
                        {
                            if (idnum == num)
                            {
                                duplicate = true;
                                break;
                            }

                        }
                        if (duplicate)
                        {
                            Console.WriteLine("Duplicate ID");
                        }
                        else
                        {
                            isUniqueID = true;
                            id[i] = idnum;
                            cars[i] = new(make, year, price, idnum);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                
            }
            Array.Sort(id, cars);
            foreach(var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
         
        }
        internal class AutoMobile
        {
            private string _make { get; set; }
            private int _year { get; set; }
            private decimal _price { get; set; }
            private int _id { get; set; }

            public AutoMobile(string make, int year, decimal price, int id)
            {
                _make = make;
                _year = year;
                _price = price;
                _id = id;
            }
            public override string ToString()
            {
                return $"Make : {_make}\nYear: {_year}\nPrice: {_price.ToString("c")}\nId: {_id}\n\n";
            }
        }
    }
}


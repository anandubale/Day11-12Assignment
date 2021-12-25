using System;

namespace StockManagementAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read in Stock Names, Number of Share, Share Price.

            // Print a Stock Report with total value of each Stock and the total value of Stock.
            //I/P -> N number of Stocks, for Each Stock Read In the Share Name, Number of
            //Share, and Share Price

            //Logic->Calculate the value of each stock and the total value
            //Print the Stock Report.
            StockDetails stock = new StockDetails();
            Console.WriteLine("Enter Number Of Stocks:-");
            int NumberOfStocks = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NumberOfStocks; i++)
            {
                Console.WriteLine("Enter ShareName: ");
                string ShareName = Console.ReadLine();

                Console.WriteLine("Enter Total Number Of Shares: ");
                int NoOfShares = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Price Per Share: ");
                int PricePerEachShare = int.Parse(Console.ReadLine());

                stock.Stockvalue(NoOfShares, PricePerEachShare, ShareName);
            }
        }

        }
    }
}

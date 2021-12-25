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
            Console.WriteLine("Enter 1 is you want to add another stock- \nEnter 2 if want to display existing stock- \nEnter 3 if you want to calculate tatal value of existing stocks- \n Enter Anythings if you want to Quite.");
            var newshareprofile = new NewShareProfile();
            while (true)
            {
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Console.WriteLine("Enter Share Name: ");
                        string ShareName = Console.ReadLine();

                        Console.WriteLine("Enter Number Of Share: ");
                        int NumberOfShare = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Price Per Share: ");
                        int PricePerShare = int.Parse(Console.ReadLine());

                        var newStock = new StockDetails(ShareName, NumberOfShare, PricePerShare);
                        newshareprofile.AddNewStock(newStock);
                        break;
                    case 2:
                        newshareprofile.Display();
                        break;
                    case 3:
                        newshareprofile.ValueOfShare();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
                Console.WriteLine("Enter 1 is you want to add another stock and \n Enter 2 if want to display existing stock \n Enter 3 if you want to calculate tatal value of existing stocks \n Enter Anythings if you want to Quite.");

            }

        }
    }
}

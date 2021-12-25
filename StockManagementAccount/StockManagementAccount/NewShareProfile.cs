using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementAccount
{
    class NewShareProfile
    {
        private List<StockDetails> stockDetails { get; set; } = new List<StockDetails>();
        //we need class which will add new stock details:
        public void AddNewStock(StockDetails StockDetails)
        {
            stockDetails.Add(StockDetails);
        }
        
        public void Display()
        {
            foreach(var StockDetails in stockDetails)
            {
                Console.WriteLine(StockDetails.ShareName);
                Console.WriteLine(StockDetails.NumberOfShare);
                Console.WriteLine(StockDetails.PriceOfShare);


            }
        }
        //public void TotalValueOfShare(int numberOfShare, int priceOfShare)
        //{
        //    Console.WriteLine("TOTAL OF Share is : ", numberOfShare * priceOfShare);   
        //}
        public void ValueOfShare()
        {
            foreach (var StockDetails in stockDetails)
            {   
                Console.WriteLine(StockDetails.ShareName);
                Console.WriteLine(StockDetails.NumberOfShare);
                Console.WriteLine(StockDetails.PriceOfShare);
                Console.WriteLine("Total value of Share is: ", StockDetails.NumberOfShare * StockDetails.PriceOfShare);


            }

        }
    }
}

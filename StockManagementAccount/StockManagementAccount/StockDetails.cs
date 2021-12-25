using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementAccount
{
    class StockDetails //we are declaring this calss so we can use this in List.
    {
  
        
            public int totalshare = 0;
            public int totalPrice = 0;
            public void Stockvalue(int p, int q, string r)
            {
                int stockPrice = p * q;
                Console.WriteLine("The Price for stock " + r + " shares is :  " + stockPrice);
                totalPrice += (p * q);
                Console.WriteLine("the total price of the stock is  " + totalPrice);
            }
        
}

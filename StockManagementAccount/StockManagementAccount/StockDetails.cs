using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementAccount
{
    class StockDetails //we are declaring this calss so we can use this in List.
    {   
        public StockDetails(string shareName,int  numberOfShare,int  priceOfShare)
        {
            ShareName = shareName;
            NumberOfShare = numberOfShare;
            PriceOfShare = priceOfShare;

        }
        public string ShareName { get; set; }
        public int NumberOfShare { get; set; }
        public int PriceOfShare { get;  set; }
    }
}

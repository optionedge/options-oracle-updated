using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOServerNSE.Models
{
    public class OptionChainItem
    {
        public double strikePrice { get; set; }
        public string expiryDate { get; set; }
        public string underlying { get; set; }
        public string identifier { get; set; }
        public double openInterest { get; set; }
        public double changeinOpenInterest { get; set; }
        public double pchangeinOpenInterest { get; set; }
        public int totalTradedVolume { get; set; }
        public double impliedVolatility { get; set; }
        public double lastPrice { get; set; }
        public double change { get; set; }
        public double pChange { get; set; }
        public int totalBuyQuantity { get; set; }
        public int totalSellQuantity { get; set; }
        public int bidQty { get; set; }
        public double bidprice { get; set; }
        public int askQty { get; set; }
        public double askPrice { get; set; }
        public decimal underlyingValue { get; set; }
    }
}

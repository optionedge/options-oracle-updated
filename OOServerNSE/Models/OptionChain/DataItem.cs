using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOServerNSE.Models
{
    public class DataItem
    {
        public double strikePrice { get; set; }
        public string expiryDate { get; set; }

        public OptionChainItem CE { get; set; }
        public OptionChainItem PE { get; set; }
    }
}

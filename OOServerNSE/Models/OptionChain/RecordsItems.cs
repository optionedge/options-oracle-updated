using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOServerNSE.Models
{
    public class RecordsItems
    {
        public string[] expiryDates { get; set; }
        public DataItem[] data { get; set; }
        public int[] strikePrices { get; set; }
        public double underlyingValue { get; set; }
        public DateTime timestamp { get; set; }
    }
}

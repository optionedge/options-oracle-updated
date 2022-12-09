using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOServerNSE.Models
{
    public class NSEQuote
    {
        public QuoteItem[] data { get; set; }
        public QuoteDate dates { get; set; }
        public DateTime timestamp { get; set; }
        public int advances { get; set; }
        public int declines { get; set; }
        public int unchanged { get; set; }
    }
}

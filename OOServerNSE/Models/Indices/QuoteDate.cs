using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOServerNSE.Models
{
    public class QuoteDate
    {
        public string previousDay { get; set; }
        public string oneWeekAgo { get; set; }
        public string oneMonthAgo { get; set; }
        public string oneYearAgo { get; set; }
        public string date30dAgo { get; set; }
        public string date365dAgo { get; set; }
    }
}

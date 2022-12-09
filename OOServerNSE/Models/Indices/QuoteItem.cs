using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOServerNSE.Models
{
    public class QuoteItem
    {
        public string key { get; set; }
        public string index { get; set; }
        public string indexSymbol { get; set; }
        public double last { get; set; }
        public double variation { get; set; }
        public double percentChange { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double previousClose { get; set; }
        public double yearHigh { get; set; }
        public double yearLow { get; set; }
        public string pe { get; set; }
        public string pb { get; set; }
        public string dy { get; set; }
        public int declines { get; set; }
        public int advances { get; set; }
        public int unchanged { get; set; }
        public string perChange365d { get; set; }
        public string date365dAgo { get; set; }
        public string chart365dPath { get; set; }
        public string date30dAgo { get; set; }
        public double perChange30d { get; set; }
        public string chart30dPath { get; set; }
        public string chartTodayPath { get; set; }
        public double previousDay { get; set; }
        public double oneWeekAgo { get; set; }
        public double oneMonthAgo { get; set; }
    }
}

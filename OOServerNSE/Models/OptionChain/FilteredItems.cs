using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOServerNSE.Models
{
    public class FilteredItems
    {
        public DataItem[] data { get; set; }
        public OIVolume CE { get; set; }
        public OIVolume PE { get; set; }
    }
}

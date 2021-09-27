using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMTracker.Models
{
    public class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get;}
        public string Type { get; }
        public string Amount { get; set; }
        public string UOM { get; set; }
        public string notes { get; set; }
        public string collectionTime { get; set; }
        public string UserID { get;}
    }
}

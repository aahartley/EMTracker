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
        //namespace? proper syntax for class relation
        public string Location { get; set; }
        /*
        public string Type { get; }
        public double Amount { get; set; }
        public string UOM { get; set; }
        public string notes { get; set; }
        public DateTimeOffset collectionTime { get; set; }
    //Referenced from Login
        public Login UserID { get; set; }
        public string status { get;set;}*/
    }
}

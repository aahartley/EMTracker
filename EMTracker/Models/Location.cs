using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMTracker.Models
{
    public class Location
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string LType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMTracker.Models
{
    public class Results
    {
        public string Component { get; set; }
        public double value { get; set; }
        public Sample Sample { get; set; }
    }
}

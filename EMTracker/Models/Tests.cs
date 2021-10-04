using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMTracker.Models
{
    public class Tests
    {
        //relating back to sample for both sample and analysis
        public Sample Sample { get; set; }
    
        public Analysis Analysis { get; set; }
             
        public string Instrument { get; set; }
        public DateTimeOffset Time { get; set; }
        public Login Login { get; set; }
    




    }
}

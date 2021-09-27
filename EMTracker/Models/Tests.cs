using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMTracker.Models
{
    public class Tests
    {
        public Sample
            GetSample;
        public Analysis
             GetAnalysis;
        public string Instrument { get; set; }
        public DateTimeOffset Time { get; set; }
        public Login
            GetUserID;




    }
}

using System;
using System.Collections.Generic;
namespace Hibird_Theory_Backend.Models
{
    public class EconIndicator
    {
        public string sectorname {get; set;}
        public double co2 {get; set;}
        public double gdp {get; set;}
        public double employment {get; set;} //set to "BeforeCovid" or "AfterCovid"
        public double fossil {get; set;}
        public double nonfossil {get; set;}
    }

    public class PizzaTotal
    {
        public int commitments {get; set;}
        public int amount {get; set;}

        public List<EconIndicator> sectors {get; set;}
    }
}
using System;
using System.Collections.Generic;
namespace Hibird_Theory_Backend.Models
{
    public class EconIndicator
    {
        public string sectorname {get; set;}
        public float co2 {get; set;}
        public float gdp {get; set;}
        public float employment {get; set;} //set to "BeforeCovid" or "AfterCovid"
        public float fossil {get; set;}
        public float nonfossil {get; set;}
    }

    public class PizzaTotal
    {
        public int commitments {get; set;}
        public float amount {get; set;}

        public List<EconIndicator> sectors {get; set;}
    }
}
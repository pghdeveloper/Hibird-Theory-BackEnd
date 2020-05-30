using System;

namespace Hibird_Theory_Backend.Models
{
    public class CovidData
    {
        public string Time {get; set;} //set to "BeforeCovid" or "AfterCovid"
        public float Amount {get; set;} 
    }
}
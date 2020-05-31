
namespace Hibird_Theory_Backend.Models
{
    public class EconIndicator
    {
        public string sectorName {get; set;}
        public float CO2 {get; set;}
        public float GDP {get; set;}
        public float Employment {get; set;} //set to "BeforeCovid" or "AfterCovid"
        public float Fossil {get; set;}
        public float NonFossil {get; set;}
    }
}
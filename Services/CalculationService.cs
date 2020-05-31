using Hibird_Theory_Backend.Interfaces;
using Hibird_Theory_Backend.Models;
using Newtonsoft.Json;
using System.IO;

namespace Hibird_Theory_Backend.Services
{
    public class CalculationService: ICalculationService
    {
        public CalculationService ()
        {

        }

        public PizzaTotal Calculation(int pizzaCommitments)
        {
            //calculatione 5
            //convert pizza committments to dollar amount
            var dollarAmount = pizzaCommitments * .000015;

            // read demand vector (86 values)
            var finalDemand = JsonConvert.DeserializeObject<LeonMatrix>(System.IO.File.ReadAllText("fakefinaldemand.json"));

            // add dolarAmount to demand[i], where i is index of foor service
            finalDemand.v81 = finalDemand.v81 + dollarAmount;
            // add 5 dollar (deliveary) to demand[j], j is index of "Transit & Ground Passengers"
            finalDemand.v49 = finalDemand.v49 + .000005;
            // as result updated demand
            string json = JsonConvert.SerializeObject(finalDemand, Formatting.Indented);
            // persist updart demand
            File.WriteAllText("fakefinaldemand.json", json);

            // multiply (matrix operation) leonmatrix (86x86) by demand vector (86)
            // result leonresult vector (86)

            // multiply (loop though each value) leonresult  (86) by coeff (86) to get indicators
            // result new dynamicwithcommitments.json
            // persist dynamicwithcommitments.json

            // return dynamicwithcommitments.json

            //Take into account of 5 dollar fixed price for each committment
            //the total amount of the pizza will be to the final demand
            //5 dollar to Other Intenet services
            // multiply demand and L matrix to generate total output (matrix mult)
            // total output multiply to coeffs to generate output indicators (N mtrix mult)
            // output indicators as json

            // demand vector must to updated through each call
            var result = JsonConvert.DeserializeObject<PizzaTotal>(System.IO.File.ReadAllText("dynamicwithcommitments.json")); 

            //write file to dynamic json
            File.WriteAllText("dynamicwithcommitments.json", JsonConvert.SerializeObject(result));
            return result;
        }
    }
}
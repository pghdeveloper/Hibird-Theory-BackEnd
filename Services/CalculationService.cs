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
            var dollarAmount = pizzaCommitments * 15;

            // read demand vector (86 values)
            // add dolarAmount to demand[i], where i is index of foor service
            // add 5 dollar (deliveary) to demand[j], j is index of "Other informat"
            // as result updated demand
            // persist updare demand

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
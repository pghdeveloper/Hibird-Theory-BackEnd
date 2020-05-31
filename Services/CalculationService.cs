using Hibird_Theory_Backend.Interfaces;
using Hibird_Theory_Backend.Models;
using Newtonsoft.Json;

namespace Hibird_Theory_Backend.Services
{
    public class CalculationService: ICalculationService
    {
        public CalculationService ()
        {

        }

        public PizzaTotal Calculation(int pizzaCommitments)
        {
            //calculation
            //convert pizza committments to dollar amount
            //Take into account of 5 dollar fixed price for each committment
            //the total amount of the pizza will be to the final demand
            //5 dollar to Other Intenet services
            // multiply demand and L matrix to generate total output (matrix mult)
            // total output multiply to coeffs to generate output indicators (N mtrix mult)
            // output indicators as json

            // demand vector must to updated through each call
            var result = JsonConvert.DeserializeObject<PizzaTotal>(System.IO.File.ReadAllText("dynamicwithcommitments.json")); 
            return result;
        }
    }
}
using Hibird_Theory_Backend.Models;

namespace Hibird_Theory_Backend.Interfaces
{
    public interface ICalculationService{
        PizzaTotal Calculation(int pizzaCommitments);

        void TestCalculation();
    }
}
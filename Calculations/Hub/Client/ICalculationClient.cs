using Calculations.Domain;

namespace Calculations.Hub.Client;

public interface ICalculationClient
{
    Task EquationsCalculated(IDictionary<int, CalculationResult> message);
}
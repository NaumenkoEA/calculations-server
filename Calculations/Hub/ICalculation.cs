using Calculations.Domain;

namespace Calculations.Hub;

public interface ICalculationHub
{
    // Task CalculateEquations(CalculateEquationsCommand command);
    Task<List<CalculationResult>> GetHistory();
}
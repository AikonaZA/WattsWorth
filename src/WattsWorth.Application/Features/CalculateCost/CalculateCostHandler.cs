using MediatR;
using WattsWorth.Infrastructure.Repositories;

namespace WattsWorth.Application.Features.CalculateCost;

public class CalculateCostHandler(IPayBracketRepository repository)
    : IRequestHandler<CalculateCostRequest, CalculateCostResponse>
{
    public async Task<CalculateCostResponse> Handle(CalculateCostRequest request, CancellationToken cancellationToken)
    {
        var payBrackets = await repository.GetAllPayBracketsAsync();
        var unitsToBuy = (request.DaysRemaining * request.AvgDailyUsage) - request.CurrentUnits;

        if (unitsToBuy <= 0)
        {
            return new CalculateCostResponse
            {
                TotalUnitsNeeded = 0,
                TotalCost = 0
            };
        }

        decimal totalCost = 0;
        decimal remainingUnits = unitsToBuy;
        int previousLimit = 0;

        foreach (var bracket in payBrackets)
        {
            if (remainingUnits <= 0) break;

            int unitsInBracket = Math.Min(bracket.MaxUnits - previousLimit, (int)remainingUnits);
            totalCost += unitsInBracket * bracket.PricePerUnit;
            remainingUnits -= unitsInBracket;
            previousLimit = bracket.MaxUnits;
        }

        return new CalculateCostResponse
        {
            TotalUnitsNeeded = unitsToBuy,
            TotalCost = totalCost
        };
    }
}


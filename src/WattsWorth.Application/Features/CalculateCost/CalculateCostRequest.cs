using MediatR;

namespace WattsWorth.Application.Features.CalculateCost;

public class CalculateCostRequest : IRequest<CalculateCostResponse>
{
    public int CurrentUnits { get; set; }
    public int DaysRemaining { get; set; }
    public decimal AvgDailyUsage { get; set; }
}


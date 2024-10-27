using Carter;
using MediatR;
using WattsWorth.Application.Features.CalculateCost;

namespace WattsWorth.ApiService.Modules;

public class CalculateCostModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/calculate-cost", async (CalculateCostRequest request, IMediator mediator) =>
        {
            var response = await mediator.Send(request);
            return Results.Ok(response);
        });
    }
}
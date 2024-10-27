using Carter;
using MediatR;
using WattsWorth.Application.Features.GetPayBrackets;

namespace WattsWorth.ApiService.Modules;

public class GetPayBracketsModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/pay-brackets", async (IMediator mediator) =>
        {
            var response = await mediator.Send(new GetPayBracketsRequest());
            return Results.Ok(response);
        });
    }
}


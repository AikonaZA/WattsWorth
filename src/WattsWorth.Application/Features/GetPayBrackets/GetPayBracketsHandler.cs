using MediatR;
using WattsWorth.Infrastructure.Repositories;

namespace WattsWorth.Application.Features.GetPayBrackets;

public class GetPayBracketsHandler(IPayBracketRepository repository)
    : IRequestHandler<GetPayBracketsRequest, GetPayBracketsResponse>
{
    public async Task<GetPayBracketsResponse> Handle(GetPayBracketsRequest request, CancellationToken cancellationToken)
    {
        var payBrackets = await repository.GetAllPayBracketsAsync();
        return new GetPayBracketsResponse
        {
            PayBrackets = payBrackets
        };
    }
}


using WattsWorth.Core.Entities;

namespace WattsWorth.Application.Features.GetPayBrackets;

public class GetPayBracketsResponse
{
    public IEnumerable<PayBracket>? PayBrackets { get; set; }
}
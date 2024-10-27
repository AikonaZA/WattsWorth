using WattsWorth.Core.Entities;

namespace WattsWorth.Infrastructure.Repositories;

public interface IPayBracketRepository
{
    Task<IEnumerable<PayBracket>> GetAllPayBracketsAsync();
    Task AddPayBracketAsync(PayBracket payBracket);
    // Additional methods for updating and deleting can be added here if needed.
}

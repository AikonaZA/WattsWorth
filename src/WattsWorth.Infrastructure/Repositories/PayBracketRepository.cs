using Microsoft.EntityFrameworkCore;
using WattsWorth.Core.Entities;
using WattsWorth.Infrastructure.Data;

namespace WattsWorth.Infrastructure.Repositories;

public class PayBracketRepository(ApplicationDbContext context) : IPayBracketRepository
{
    public async Task<IEnumerable<PayBracket>> GetAllPayBracketsAsync()
    {
        return await context.PayBrackets.ToListAsync();
    }

    public async Task AddPayBracketAsync(PayBracket payBracket)
    {
        await context.PayBrackets.AddAsync(payBracket);
        await context.SaveChangesAsync();
    }
}

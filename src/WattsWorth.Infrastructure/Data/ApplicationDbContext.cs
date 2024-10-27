using Microsoft.EntityFrameworkCore;
using WattsWorth.Core.Entities;

namespace WattsWorth.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<PayBracket> PayBrackets { get; set; }

    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<ElectricityPurchase> ElectricityPurchases { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure one-to-one relationship between Transaction and ElectricityPurchase
        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.ElectricityPurchase)
            .WithOne(ep => ep.Transaction)
            .HasForeignKey<ElectricityPurchase>(ep => ep.TransactionId);
        modelBuilder.Entity<PayBracket>();
        // Other model configurations can be done here as needed
        base.OnModelCreating(modelBuilder);
    }
}

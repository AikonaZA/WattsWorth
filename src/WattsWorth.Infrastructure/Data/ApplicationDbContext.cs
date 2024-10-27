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
        modelBuilder.Entity<PayBracket>();
        // Set up the one-to-one relationship between Transaction and ElectricityPurchase if needed
        modelBuilder.Entity<ElectricityPurchase>()
            .HasOne(p => p.Transaction)
            .WithMany()
            .HasForeignKey(p => p.TransactionId);

        base.OnModelCreating(modelBuilder);
    }
}
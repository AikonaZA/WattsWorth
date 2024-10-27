namespace WattsWorth.Core.Entities;

public class Transaction : BaseEntity
{
    public DateTime TransactionDate { get; set; } // When the units were recorded or updated
    public decimal Units { get; set; } // Current number of units remaining
    public string Description { get; set; } // Optional description
}
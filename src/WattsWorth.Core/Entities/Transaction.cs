namespace WattsWorth.Core.Entities;

public class Transaction : BaseEntity
{
    public DateTime TransactionDate { get; set; } // Transaction timestamp
    public decimal? Units { get; set; } // Number of units (nullable)
    public decimal? Price { get; set; } // Price (nullable)
    public decimal? Debit { get; set; } // Debit amount for consumed units
    public decimal? Credit { get; set; } // Credit amount for purchased units
    public decimal? UnitCost { get; set; } // Price per unit
    public decimal? UnitDifference { get; set; } // Difference in units
    public int? HourDifference { get; set; } // Hours difference between transactions
    public int? MinuteDifference { get; set; } // Minutes difference between transactions
    public decimal? UnitsPerHour { get; set; } // Units consumed per hour (calculated)
    public string Description { get; set; } // Description (e.g., appliance used)
    public int Day { get; set; } // Day of the transaction
    public string Month { get; set; } // Month of the transaction (e.g., "Jul")
    public int Year { get; set; } // Year of the transaction

    // Navigation property for ElectricityPurchase if this transaction is a purchase
    public ElectricityPurchase ElectricityPurchase { get; set; }
}

